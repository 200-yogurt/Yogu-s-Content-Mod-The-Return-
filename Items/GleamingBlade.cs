using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YogusContentMod.Items
{
	public class GleamingBlade : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Gleaming Blade");
			Tooltip.SetDefault("A Mix of the Gold Broadsword and Platinum Broadsword\nit will generate a decent range slash that will leave shiny particles behind, They explode on enemy contact");
		}

		public override void SetDefaults()
		{
			Item.damage = 17;
			Item.DamageType = DamageClass.Melee;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 15;
			Item.useAnimation = 20;
			Item.useStyle = 1;
			Item.knockBack = 4;
			Item.value = Item.sellPrice (0, 1, 15, 30);
			Item.rare = 3;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;



		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.GoldBroadsword, 1);
			recipe.AddIngredient(ItemID.PlatinumBroadsword, 1);
			recipe.AddIngredient(ItemID.Star, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
}