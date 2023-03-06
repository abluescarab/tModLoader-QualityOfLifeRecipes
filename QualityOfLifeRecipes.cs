using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

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
