﻿using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace MagicStorage.Items
{
	public class CraftingAccess : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Storage Crafting Interface");
			DisplayName.AddTranslation(GameCulture.Russian, "Модуль Создания Предметов");
			DisplayName.AddTranslation(GameCulture.Polish, "Interfejs Rzemieślniczy Magazynu");
			DisplayName.AddTranslation(GameCulture.French, "Interface de Stockage Artisanat");
			DisplayName.AddTranslation(GameCulture.Spanish, "Interfaz de Elaboración de almacenamiento");
		}

		public override void SetDefaults()
		{
			item.width = 26;
			item.height = 26;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.rare = 1;
			item.value = Item.sellPrice(0, 1, 16, 25);
			item.createTile = mod.TileType("CraftingAccess");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "StorageComponent");
			recipe.AddRecipeGroup("MagicStorage:AnyDiamond", 1);
			if (MagicStorage.legendMod == null)
			{
				recipe.AddIngredient(ItemID.Sapphire, 3);
			}
			else
			{
				recipe.AddRecipeGroup("MagicStorage:AnySapphire", 5);
			}
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}

