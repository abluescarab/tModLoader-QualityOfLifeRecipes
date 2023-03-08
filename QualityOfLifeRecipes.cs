using Terraria.ModLoader;

/*
 * TODO:
 * add banners:
 *  ocean
 *  cavern
 *  granite cave
 *  glowing mushroom
 *  snow
 *  jungle
 *  desert
 *  underworld
 *  corruption/crimson
 *  hallow
 *  blood moon
 *  old one's army
 */

namespace QualityOfLifeRecipes {
    public class QualityOfLifeRecipes : Mod {
        public QualityOfLifeRecipes() {
            ContentAutoloadingEnabled = true;
            BackgroundAutoloadingEnabled = true;
            GoreAutoloadingEnabled = true;
            MusicAutoloadingEnabled = true;
        }

        public override void PostSetupContent() {
            if(ModLoader.TryGetMod("WikiSearch", out Mod wikiSearch)) {
                wikiSearch.Call("RegisterMod", this, "https://github.com/abluescarab/tModLoader-QualityOfLifeRecipes/wiki/%s");
            }
        }
    }
}
