using System.Collections.Generic;

public class Ability
{
    public string name { get; set; }
    public string url { get; set; }
}

public class Ability2
{
    public Ability ability { get; set; }
    public bool is_hidden { get; set; }
    public int slot { get; set; }
}

public class Form
{
    public string name { get; set; }
    public string url { get; set; }
}

public class Version
{
    public string name { get; set; }
    public string url { get; set; }
}

public class GameIndice
{
    public int game_index { get; set; }
    public Version version { get; set; }
}

public class Move
{
    public string name { get; set; }
    public string url { get; set; }
}

public class MoveLearnMethod
{
    public string name { get; set; }
    public string url { get; set; }
}

public class VersionGroup
{
    public string name { get; set; }
    public string url { get; set; }
}

public class VersionGroupDetail
{
    public int level_learned_at { get; set; }
    public MoveLearnMethod move_learn_method { get; set; }
    public VersionGroup version_group { get; set; }
}

public class Move2
{
    public Move move { get; set; }
    public IList<VersionGroupDetail> version_group_details { get; set; }
}

public class Species
{
    public string name { get; set; }
    public string url { get; set; }
}

public class DreamWorld
{
    public string front_default { get; set; }
    public object front_female { get; set; }
}

public class Home
{
    public string front_default { get; set; }
    public object front_female { get; set; }
    public string front_shiny { get; set; }
    public object front_shiny_female { get; set; }
}

public class OfficialArtwork
{
    public string front_default { get; set; }
}

public class Other
{
    public DreamWorld dream_world { get; set; }
    public Home home { get; set; }
    public OfficialArtwork official_artwork { get; set; }
    }

    public class RedBlue
{
    public string back_default { get; set; }
    public string back_gray { get; set; }
    public string back_transparent { get; set; }
    public string front_default { get; set; }
    public string front_gray { get; set; }
    public string front_transparent { get; set; }
}

public class Yellow
{
    public string back_default { get; set; }
    public string back_gray { get; set; }
    public string back_transparent { get; set; }
    public string front_default { get; set; }
    public string front_gray { get; set; }
    public string front_transparent { get; set; }
}

public class GenerationI
{
    public RedBlue red_blue { get; set; }
public Yellow yellow { get; set; }
    }

    public class Crystal
{
    public string back_default { get; set; }
    public string back_shiny { get; set; }
    public string back_shiny_transparent { get; set; }
    public string back_transparent { get; set; }
    public string front_default { get; set; }
    public string front_shiny { get; set; }
    public string front_shiny_transparent { get; set; }
    public string front_transparent { get; set; }
}

public class Gold
{
    public string back_default { get; set; }
    public string back_shiny { get; set; }
    public string front_default { get; set; }
    public string front_shiny { get; set; }
    public string front_transparent { get; set; }
}

public class Silver
{
    public string back_default { get; set; }
    public string back_shiny { get; set; }
    public string front_default { get; set; }
    public string front_shiny { get; set; }
    public string front_transparent { get; set; }
}

public class GenerationIi
{
    public Crystal crystal { get; set; }
    public Gold gold { get; set; }
    public Silver silver { get; set; }
}

public class Emerald
{
    public string front_default { get; set; }
    public string front_shiny { get; set; }
}

public class FireredLeafgreen
{
    public string back_default { get; set; }
    public string back_shiny { get; set; }
    public string front_default { get; set; }
    public string front_shiny { get; set; }
}

public class RubySapphire
{
    public string back_default { get; set; }
    public string back_shiny { get; set; }
    public string front_default { get; set; }
    public string front_shiny { get; set; }
}

public class GenerationIii
{
    public Emerald emerald { get; set; }
    public FireredLeafgreen firered_leafgreen { get; set; }
    public RubySapphire ruby_sapphire { get; set; }
}

    public class DiamondPearl
{
    public string back_default { get; set; }
    public object back_female { get; set; }
    public string back_shiny { get; set; }
    public object back_shiny_female { get; set; }
    public string front_default { get; set; }
    public object front_female { get; set; }
    public string front_shiny { get; set; }
    public object front_shiny_female { get; set; }
}

public class HeartgoldSoulsilver
{
    public string back_default { get; set; }
    public object back_female { get; set; }
    public string back_shiny { get; set; }
    public object back_shiny_female { get; set; }
    public string front_default { get; set; }
    public object front_female { get; set; }
    public string front_shiny { get; set; }
    public object front_shiny_female { get; set; }
}

public class Platinum
{
    public string back_default { get; set; }
    public object back_female { get; set; }
    public string back_shiny { get; set; }
    public object back_shiny_female { get; set; }
    public string front_default { get; set; }
    public object front_female { get; set; }
    public string front_shiny { get; set; }
    public object front_shiny_female { get; set; }
}

public class GenerationIv
{
    public DiamondPearl diamond_pearl { get; set; }
public HeartgoldSoulsilver heartgold_soulsilver { get; set; }
public Platinum platinum { get; set; }
    }

    public class Animated
{
    public string back_default { get; set; }
    public object back_female { get; set; }
    public string back_shiny { get; set; }
    public object back_shiny_female { get; set; }
    public string front_default { get; set; }
    public object front_female { get; set; }
    public string front_shiny { get; set; }
    public object front_shiny_female { get; set; }
}

public class BlackWhite
{
    public Animated animated { get; set; }
    public string back_default { get; set; }
    public object back_female { get; set; }
    public string back_shiny { get; set; }
    public object back_shiny_female { get; set; }
    public string front_default { get; set; }
    public object front_female { get; set; }
    public string front_shiny { get; set; }
    public object front_shiny_female { get; set; }
}

public class GenerationV
{
    public BlackWhite black_white { get; set; }
    }

    public class OmegarubyAlphasapphire
{
    public string front_default { get; set; }
    public object front_female { get; set; }
    public string front_shiny { get; set; }
    public object front_shiny_female { get; set; }
}

public class XY
{
    public string front_default { get; set; }
    public object front_female { get; set; }
    public string front_shiny { get; set; }
    public object front_shiny_female { get; set; }
}

public class GenerationVi
{
    public OmegarubyAlphasapphire omegaruby_alphasapphire { get; set; }
public XY x_y { get; set; }
    }

    public class Icons
{
    public string front_default { get; set; }
    public object front_female { get; set; }
}

public class UltraSunUltraMoon
{
    public string front_default { get; set; }
    public object front_female { get; set; }
    public string front_shiny { get; set; }
    public object front_shiny_female { get; set; }
}

public class GenerationVii
{
    public Icons icons { get; set; }
    public UltraSunUltraMoon ultra_sun_ultra_moon { get; set; }
    }

    public class GenerationViii
{
    public Icons icons { get; set; }
}

public class Versions
{
    public GenerationI generation_i { get; set; }
public GenerationIi generation_ii { get; set; }
public GenerationIii generation_iii { get; set; }
public GenerationIv generation_iv { get; set; }
public GenerationV generation_v { get; set; }
public GenerationVi generation_vi { get; set; }
public GenerationVii generation_vii { get; set; }
public GenerationViii generation_viii { get; set; }
    }

    public class Sprites
{
    public string back_default { get; set; }
    public object back_female { get; set; }
    public string back_shiny { get; set; }
    public object back_shiny_female { get; set; }
    public string front_default { get; set; }
    public object front_female { get; set; }
    public string front_shiny { get; set; }
    public object front_shiny_female { get; set; }
    public Other other { get; set; }
    public Versions versions { get; set; }
}

public class Stat
{
    public string name { get; set; }
    public string url { get; set; }
}

public class Stat2
{
    public int base_stat { get; set; }
    public int effort { get; set; }
    public Stat stat { get; set; }
}

public class Type
{
    public string name { get; set; }
    public string url { get; set; }
}

public class Type2
{
    public int slot { get; set; }
    public Type type { get; set; }
}

public class pokemonJson
{
    public IList<Ability2> abilities { get; set; }
    public int base_experience { get; set; }
    public IList<Form> forms { get; set; }
    public IList<GameIndice> game_indices { get; set; }
    public int height { get; set; }
    public IList<object> held_items { get; set; }
    public int id { get; set; }
    public bool is_default { get; set; }
    public string location_area_encounters { get; set; }
    public IList<Move> moves { get; set; }
    public string name { get; set; }
    public int order { get; set; }
    public IList<object> past_types { get; set; }
    public Species species { get; set; }
    public Sprites sprites { get; set; }
    public IList<Stat> stats { get; set; }
    public IList<Type> types { get; set; }
    public int weight { get; set; }
}

