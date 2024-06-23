﻿using AncientMonkey.Projectiles;
using BTD_Mod_Helper.Api.Enums;
using BTD_Mod_Helper.Extensions;
using Il2Cpp;
using Il2CppAssets.Scripts.Data.Gameplay.Mods;
using Il2CppAssets.Scripts.Models.GenericBehaviors;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.Towers.Behaviors;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Attack;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Attack.Behaviors;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Emissions;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Emissions.Behaviors;
using Il2CppAssets.Scripts.Models.Towers.Projectiles.Behaviors;
using Il2CppAssets.Scripts.Simulation.Towers;
using Il2CppAssets.Scripts.Unity;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace AncientMonkey.Weapons
{
	public class Dart : WeaponTemplate
	{
		public override int SandboxIndex => 1;
		public override Rarity WeaponRarity => Rarity.Common;
		public override string WeaponName => "Dart";
		public override string Icon => VanillaSprites.SharpShotsUpgradeIcon;
		public override void EditTower(Tower tower)
		{
			var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
			var wpn = Game.instance.model.GetTowerFromId("DartMonkey").GetAttackModel().Duplicate();
			wpn.range = tower.towerModel.range;
			towerModel.AddBehavior(wpn);
			tower.UpdateRootModel(towerModel);
		}
	}
	public class Boomerang : WeaponTemplate
	{
		public override int SandboxIndex => 1;
		public override Rarity WeaponRarity => Rarity.Common;
		public override string WeaponName => "Boomerang";
		public override string Icon => VanillaSprites.ImprovedRangsUpgradeIcon;
		public override void EditTower(Tower tower)
		{
			var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
			var wpn = Game.instance.model.GetTowerFromId("BoomerangMonkey").GetAttackModel().Duplicate();
			wpn.range = tower.towerModel.range;
			towerModel.AddBehavior(wpn);
			tower.UpdateRootModel(towerModel);
		}
	}
	public class Tack : WeaponTemplate
	{
		public override int SandboxIndex => 1;
		public override Rarity WeaponRarity => Rarity.Common;
		public override string Icon => VanillaSprites.FasterShootingUpgradeIcon;
		public override string WeaponName => "Tack";
		public override void EditTower(Tower tower)
		{
			var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
			var wpn = Game.instance.model.GetTowerFromId("TackShooter").GetAttackModel().Duplicate();
			wpn.range = tower.towerModel.range;
			towerModel.AddBehavior(wpn);
			tower.UpdateRootModel(towerModel);
		}
	}
	public class Nail : WeaponTemplate
	{
		public override int SandboxIndex => 1;
		public override Rarity WeaponRarity => Rarity.Common;
		public override string Icon => VanillaSprites.LargerServiceAreaUpgradeIcon;
		public override string WeaponName => "Nail";
		public override void EditTower(Tower tower)
		{
			var wpn = Game.instance.model.GetTowerFromId("EngineerMonkey").GetAttackModel().Duplicate();
			wpn.range = tower.towerModel.range;
			var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
			towerModel.AddBehavior(wpn);
			tower.UpdateRootModel(towerModel);
		}
	}
	public class Glue : WeaponTemplate
	{
		public override int SandboxIndex => 1;
		public override Rarity WeaponRarity => Rarity.Common;
		public override string Icon => VanillaSprites.GlueSoakUpgradeIcon;
		public override string WeaponName => "Glue";
		public override bool IsLead => true;
		public override void EditTower(Tower tower)
		{
			var wpn = Game.instance.model.GetTowerFromId("GlueGunner").GetAttackModel().Duplicate();
			wpn.range = tower.towerModel.range;
			var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
			towerModel.AddBehavior(wpn);
			tower.UpdateRootModel(towerModel);
		}
	}
	public class Bomb : WeaponTemplate
	{
		public override int SandboxIndex => 1;
		public override Rarity WeaponRarity => Rarity.Common;
		public override string Icon => VanillaSprites.BiggerBombsUpgradeIcon;
		public override string WeaponName => "Bomb";
		public override bool IsLead => true;
		public override void EditTower(Tower tower)
		{
			var wpn = Game.instance.model.GetTowerFromId("BombShooter").GetAttackModel().Duplicate();
			wpn.range = tower.towerModel.range;
			var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
			towerModel.AddBehavior(wpn);
			tower.UpdateRootModel(towerModel);
		}
	}
	public class Magic : WeaponTemplate
	{
		public override int SandboxIndex => 1;
		public override Rarity WeaponRarity => Rarity.Common;
		public override string Icon => VanillaSprites.IntenseMagicUpgradeIcon;
		public override string WeaponName => "Magic";
		public override void EditTower(Tower tower)
		{
			var wpn = Game.instance.model.GetTowerFromId("WizardMonkey").GetAttackModel().Duplicate();
			wpn.range = tower.towerModel.range;
			var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
			towerModel.AddBehavior(wpn);
			tower.UpdateRootModel(towerModel);
		}
	}
	public class Quincy : WeaponTemplate
	{
		public override int SandboxIndex => 1;
		public override Rarity WeaponRarity => Rarity.Common;
		public override string Icon => VanillaSprites.QuincyIcon;
		public override string WeaponName => "Quincy";
		public override void EditTower(Tower tower)
		{
			var wpn = Game.instance.model.GetTowerFromId("Quincy").GetAttackModel().Duplicate();
			wpn.range = tower.towerModel.range;
			var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
			towerModel.AddBehavior(wpn);
			tower.UpdateRootModel(towerModel);
		}
	}
	public class Shuriken : WeaponTemplate
	{
		public override int SandboxIndex => 1;
		public override Rarity WeaponRarity => Rarity.Common;
		public override string Icon => VanillaSprites.SharpShurikensUpgradeIcon;
		public override string WeaponName => "Shuriken";
		public override bool IsCamo => true;
		public override void EditTower(Tower tower)
		{
			var wpn = Game.instance.model.GetTowerFromId("NinjaMonkey").GetAttackModel().Duplicate();
			wpn.range = tower.towerModel.range;
			var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
			towerModel.AddBehavior(wpn);
			tower.UpdateRootModel(towerModel);
		}
	}
	public class Ezili : WeaponTemplate
	{
		public override int SandboxIndex => 1;
		public override Rarity WeaponRarity => Rarity.Common;
		public override string Icon => VanillaSprites.EziliIcon;
		public override string WeaponName => "Ezili";
		public override bool IsCamo => true;
		public override bool IsLead => true;
		public override void EditTower(Tower tower)
		{
			var wpn = Game.instance.model.GetTowerFromId("Ezili").GetAttackModel().Duplicate();
			wpn.range = tower.towerModel.range;
			var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
			towerModel.AddBehavior(wpn);
			tower.UpdateRootModel(towerModel);
		}
	}
	public class Sniper : WeaponTemplate
	{
		public override int SandboxIndex => 1;
		public override Rarity WeaponRarity => Rarity.Common;
		public override string Icon => VanillaSprites.EvenFasterFiringUpgradeIcon;
		public override string WeaponName => "Sniper";
		public override void EditTower(Tower tower)
		{
			var wpn = Game.instance.model.GetTowerFromId("SniperMonkey").GetAttackModel().Duplicate();
			var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
			towerModel.AddBehavior(wpn);
			tower.UpdateRootModel(towerModel);
		}
	}
	public class Thorn : WeaponTemplate
	{
		public override int SandboxIndex => 1;
		public override Rarity WeaponRarity => Rarity.Common;
		public override string Icon => VanillaSprites.ThornSwarmUpgradeIcon;
		public override string WeaponName => "Thorn";
		public override void EditTower(Tower tower)
		{
			var wpn = Game.instance.model.GetTowerFromId("Druid").GetAttackModel().Duplicate();
			wpn.range = tower.towerModel.range;
			var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
			towerModel.AddBehavior(wpn);
			tower.UpdateRootModel(towerModel);
		}
	}
	public class Sub : WeaponTemplate
	{
		public override int SandboxIndex => 1;
		public override Rarity WeaponRarity => Rarity.Common;
		public override string WeaponName => "Sub";
		public override string Icon => VanillaSprites.BarbedDartsUpgradeIcon;
		public override void EditTower(Tower tower)
		{
			var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
			var wpn = Game.instance.model.GetTowerFromId("MonkeySub").GetAttackModel().Duplicate();
			wpn.range = tower.towerModel.range;
			towerModel.AddBehavior(wpn);
			tower.UpdateRootModel(towerModel);
		}
	}
	public class MonkeyAce : WeaponTemplate
	{
		public override int SandboxIndex => 1;
		public override Rarity WeaponRarity => Rarity.Common;
		public override string WeaponName => "Monkey Ace";
		public override string Icon => VanillaSprites.RapidFireUpgradeIcon;
		public override void EditTower(Tower tower)
		{
			var phoenix = Game.instance.model.GetTowerFromId("WizardMonkey-050").GetBehavior<TowerCreateTowerModel>().Duplicate();
			var ace = Game.instance.model.GetTowerFromId("MonkeyAce").GetBehavior<AirUnitModel>().Duplicate();
			var wpn = Game.instance.model.GetTowerFromId("MonkeyAce").GetBehavior<AttackAirUnitModel>().Duplicate();
			var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
			ace.AddBehavior(wpn);
			phoenix.towerModel.ApplyDisplay<blankdisplay.BlankDisplay>();
			phoenix.towerModel.RemoveBehavior<AttackModel>();
			phoenix.towerModel.RemoveBehavior<PathMovementFromScreenCenterModel>();
			phoenix.towerModel.RemoveBehavior<CreateEffectOnPlaceModel>();
			phoenix.towerModel.RemoveBehavior<Il2CppAssets.Scripts.Models.Towers.Behaviors.CreateEffectOnExpireModel>();
			phoenix.towerModel.AddBehavior(ace);

			towerModel.AddBehavior(phoenix);
			tower.UpdateRootModel(towerModel);
		}
	}
	public class Acid : WeaponTemplate
	{
		public override int SandboxIndex => 1;
		public override Rarity WeaponRarity => Rarity.Common;
		public override string WeaponName => "Acid";
		public override string Icon => VanillaSprites.LargerPotionsUpgradeIcon;
		public override bool IsLead => true;
		public override void EditTower(Tower tower)
		{
			var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
			var wpn = Game.instance.model.GetTowerFromId("Alchemist").GetAttackModel().Duplicate();
			wpn.range = tower.towerModel.range;
			towerModel.AddBehavior(wpn);
			tower.UpdateRootModel(towerModel);
		}
	}
	public class Shell : WeaponTemplate
	{
		public override int SandboxIndex => 1;
		public override Rarity WeaponRarity => Rarity.Common;
		public override string WeaponName => "Shell";
		public override string Icon => VanillaSprites.FasterReloadUpgradeIcon2;
		public override bool IsLead => true;
		public override void EditTower(Tower tower)
		{
			var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
			var wpn = Game.instance.model.GetTowerFromId("MortarMonkey").GetAttackModel().Duplicate();
			wpn.RemoveBehaviors<TargetSelectedPointModel>();
			wpn.AddBehavior(new TargetStrongModel("targetstrong", false, false));
			wpn.AddBehavior(new TargetCloseModel("targetclose", false, false));
			wpn.AddBehavior(new TargetFirstModel("targetfirst", false, false));
			wpn.AddBehavior(new TargetLastModel("targetlast", false, false));

			towerModel.AddBehavior(wpn);
			tower.UpdateRootModel(towerModel);
		}
	}
	public class Ice : WeaponTemplate
	{
		public override int SandboxIndex => 1;
		public override Rarity WeaponRarity => Rarity.Common;
		public override string WeaponName => "Ice";
		public override string Icon => VanillaSprites.PermafrostUpgradeIcon;
		public override void EditTower(Tower tower)
		{
			var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
			var wpn = Game.instance.model.GetTowerFromId("IceMonkey").GetAttackModel().Duplicate();
			wpn.range = tower.towerModel.range;
			towerModel.AddBehavior(wpn);
			tower.UpdateRootModel(towerModel);
		}
	}
	//public class SeekingDart : WeaponTemplate
	//{
	//	public override int SandboxIndex => 1;
	//	public override Rarity WeaponRarity => Rarity.Common;
	//	public override string WeaponName => "Rubber Seeking";
	//	public override string Icon => VanillaSprites.NevaMissTargetingUpgradeIcon;
	//	public override bool IsLead => true;
	//	public override Sprite CustomIcon => GetSprite("RubberSeekingIcon");
	//	public override string Description => "Dart Monkey 4th path by LynxC";
	//	public override void EditTower(Tower tower)
	//	{
	//		var seeking = Game.instance.model.GetTowerFromId("WizardMonkey-500").GetWeapon().projectile.GetBehavior<TrackTargetModel>().Duplicate();

	//		seeking.distance = 999;
	//		seeking.constantlyAquireNewTarget = true;


	//		var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
	//		var wpn = Game.instance.model.GetTowerFromId("DartMonkey").GetAttackModel().Duplicate();
	//		wpn.weapons[0].projectile.GetDamageModel().immuneBloonProperties = Il2Cpp.BloonProperties.None;
	//		wpn.weapons[0].projectile.AddBehavior(seeking);
	//		wpn.weapons[0].projectile.GetBehavior<TravelStraitModel>().Lifespan *= 4;
	//		wpn.weapons[0].projectile.pierce += 1;
	//		wpn.range = tower.towerModel.range;
	//		towerModel.AddBehavior(wpn);
	//		tower.UpdateRootModel(towerModel);
	//	}
	//}
	//public class Incendiary : WeaponTemplate
	//{
	//	public override int SandboxIndex => 1;
	//	public override Rarity WeaponRarity => Rarity.Common;
	//	public override string WeaponName => "Incendiary Bomb";
	//	public override string Icon => VanillaSprites.BiggerBombsUpgradeIcon;
	//	public override bool IsLead => true;
	//	public override Sprite CustomIcon => GetSprite("IncendiaryIcon");
	//	public override string Description => "Bomb Shooter 4th path by LynxC";
	//	public override void EditTower(Tower tower)
	//	{
	//		var fire = Game.instance.model.GetTowerFromId("MortarMonkey-002").Duplicate<TowerModel>().GetBehavior<AttackModel>().weapons[0].projectile.
	//			GetBehavior<CreateProjectileOnExhaustFractionModel>().projectile.GetBehavior<AddBehaviorToBloonModel>().Duplicate();

	//		var wpn = Game.instance.model.GetTowerFromId("BombShooter-100").GetAttackModel().Duplicate();
	//		wpn.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.AddBehavior(fire);
	//		wpn.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.collisionPasses = new int[] { 0, -1 };
	//		wpn.range = tower.towerModel.range;
	//		var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
	//		towerModel.AddBehavior(wpn);
	//		tower.UpdateRootModel(towerModel);
	//	}
	//}
	//public class Ripper : WeaponTemplate
	//{
	//	public override int SandboxIndex => 1;
	//	public override Rarity WeaponRarity => Rarity.Common;
	//	public override string WeaponName => "Ripper";
	//	public override string Icon => VanillaSprites.AcidicMixtureDipUpgradeIcon;
	//	public override Sprite CustomIcon => GetSprite("RipperIcon");
	//	public override string Description => "Buccaneer 4th path by LynxC";
	//	public override void EditTower(Tower tower)
	//	{
	//		var bleed = Game.instance.model.GetTowerFromId("Sauda 9").GetAttackModel().weapons[0].projectile.GetBehavior<AddBehaviorToBloonModel>().Duplicate();

	//		var wpn = Game.instance.model.GetTowerFromId("MonkeyBuccaneer").GetAttackModel().Duplicate();
	//		wpn.GetBehavior<RotateToTargetModel>().additionalRotation = 0;
	//		wpn.weapons[0].emission.RemoveBehavior<EmissionRotationOffTowerDirectionModel>();
	//		wpn.weapons[0].ejectX = 0;
	//		wpn.weapons[0].ejectY = 0;
	//		wpn.weapons[0].ejectX = 0;

	//		wpn.weapons[0].projectile.AddBehavior(bleed);
	//		wpn.weapons[0].projectile.collisionPasses = new[] { -1, 0, 1 };
	//		wpn.range = tower.towerModel.range;
	//		var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
	//		towerModel.AddBehavior(wpn);
	//		tower.UpdateRootModel(towerModel);
	//	}
	//}




	public class Common
	{
		public static List<string> CommonWpn = new List<string>();
		public static List<string> CommonImg = new List<string>();
		public static List<Sprite> CommonCustomImg = new List<Sprite>();
	}
}
