using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
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
			Item.useStyle = ItemUseStyleID.Swing;
			Item.knockBack = 4;
			Item.value = Item.sellPrice (0, 1, 15, 30);
			Item.rare = ItemRarityID.Blue;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
			Item.shoot = ModContent.ProjectileType<GleamingBladeProjectile>();
			Item.useTurn = true;
			Item.noUseGraphic = true;



		}

		public override void ModifyShootStats(Player player, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback)
		{
			position = player.position;
			base.ModifyShootStats(player, ref position, ref velocity, ref type, ref damage, ref knockback);
		}

		public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
		{
			return base.Shoot(player, source, position, velocity, type, damage, knockback);
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