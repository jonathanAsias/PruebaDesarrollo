using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using Newtonsoft.Json;

public class Card : MonoBehaviour
{
    public Image imagen;
    public InputField textoId;
    public Button botonConsultar;
    public Button atacar;

    [System.Serializable]
    public struct pokemon
    {
        public string nombre;
        public string imagen;
        public string experiencia;
        public string habilidades;
    }

    public pokemon datosPokemon;


    // Start is called before the first frame update
    void Start()
    {
        botonConsultar.onClick.AddListener(CosultarPokemon);
        atacar.onClick.AddListener(atacarPokemon);
        atacar.interactable = false;
    }

    private void Update()
    {
        if (textoId.text == "")
        {
            botonConsultar.interactable = false;
        }
        else {
            botonConsultar.interactable = true;
        }
    }
   
    public void CosultarPokemon() {
        StartCoroutine(GetData_pokemon(int.Parse(textoId.text)));
    }

    public void atacarPokemon() {
        Arma arma = GameObject.FindObjectOfType<Arma>();
        arma.activo = true;
        atacar.interactable = false;
    }

    IEnumerator GetData_pokemon(int numero)
    {
        string url = "https://pokeapi.co/api/v2/pokemon/" + numero;
        using (UnityWebRequest request = UnityWebRequest.Get(url))
        {
            yield return request.SendWebRequest();
            if (request.isNetworkError || request.isHttpError)
            {
                print(request.error);
            }
            else
            {
                var dataPokemon= JsonConvert.DeserializeObject<pokemonJson>(request.downloadHandler.text);
                datosPokemon.nombre = dataPokemon.name;
                datosPokemon.experiencia= dataPokemon.base_experience.ToString();
                datosPokemon.imagen = dataPokemon.sprites.other.home.front_default;
                foreach (var h in dataPokemon.abilities) {
                    datosPokemon.habilidades = h.ability.name + " - " + datosPokemon.habilidades;
                }
                StartCoroutine(LoadData(datosPokemon.nombre, datosPokemon.experiencia, datosPokemon.imagen,datosPokemon.habilidades));
            }
        }
    }

    IEnumerator LoadData(string nombre, string experiencia, string imageURL, string habilidades) {

        Text nombrePokemon = transform.GetChild(0).GetComponent<Text>();
        Text experienciaPokemon = transform.GetChild(1).GetComponent<Text>();
        Text habilitadesPokemon = transform.GetChild(2).GetComponent<Text>();
        RawImage imagenPokemon= transform.GetChild(3).GetComponent<RawImage>();

        nombrePokemon.text = "Nombre: "+ nombre;
        experienciaPokemon.text = "Experiencia: "+ experiencia;
        habilitadesPokemon.text = "Habilidades: " + habilidades;
        UnityWebRequest request = UnityWebRequestTexture.GetTexture(imageURL);
        yield return request.SendWebRequest();
        if (request.isNetworkError || request.isHttpError)
        {
            Debug.Log(request.error);
        }
        else
        {
            imagenPokemon.texture = ((DownloadHandlerTexture)request.downloadHandler).texture;
            imagenPokemon.color = Color.white;
            atacar.interactable = true;
        }
    }
}
