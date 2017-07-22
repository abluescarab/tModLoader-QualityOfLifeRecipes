using Terraria.ModLoader;

namespace QualityOfLifeRecipes {
    public class QualityOfLifeRecipes : Mod {
        public QualityOfLifeRecipes() {
            Properties = new ModProperties() {
                Autoload = true,
                AutoloadGores = true,
                AutoloadSounds = true
            };
        }
    }
}
