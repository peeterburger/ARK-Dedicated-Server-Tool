﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARK_Server_Manager.Lib
{
    public static class GameData
    {
        private static readonly DinoSpawn[] dinoSpawns = new DinoSpawn[] 
            {
                new DinoSpawn { DinoNameTag = "Anky",       SpawnWeightMultiplier = 0.1F, OverrideSpawnLimitPercentage = true, SpawnLimitPercentage = 1.0F },
                new DinoSpawn { DinoNameTag = "Ant",        SpawnWeightMultiplier = 0.1F, OverrideSpawnLimitPercentage = true, SpawnLimitPercentage = 1.0F },
                new DinoSpawn { DinoNameTag = "Argent",     SpawnWeightMultiplier = 0.1F, OverrideSpawnLimitPercentage = true, SpawnLimitPercentage = 1.0F },
                new DinoSpawn { DinoNameTag = "Bat",        SpawnWeightMultiplier = 0.1F, OverrideSpawnLimitPercentage = true, SpawnLimitPercentage = 1.0F },
                new DinoSpawn { DinoNameTag = "Bronto",     SpawnWeightMultiplier = 0.1F, OverrideSpawnLimitPercentage = true, SpawnLimitPercentage = 1.0F },
                new DinoSpawn { DinoNameTag = "Carno",      SpawnWeightMultiplier = 0.1F, OverrideSpawnLimitPercentage = true, SpawnLimitPercentage = 1.0F },
                new DinoSpawn { DinoNameTag = "Coel",       SpawnWeightMultiplier = 0.1F, OverrideSpawnLimitPercentage = true, SpawnLimitPercentage = 1.0F },
                new DinoSpawn { DinoNameTag = "Dilo",       SpawnWeightMultiplier = 0.1F, OverrideSpawnLimitPercentage = true, SpawnLimitPercentage = 1.0F },
                new DinoSpawn { DinoNameTag = "Dimo",       SpawnWeightMultiplier = 0.1F, OverrideSpawnLimitPercentage = true, SpawnLimitPercentage = 1.0F },
                new DinoSpawn { DinoNameTag = "Dodo",       SpawnWeightMultiplier = 0.1F, OverrideSpawnLimitPercentage = true, SpawnLimitPercentage = 1.0F },
                new DinoSpawn { DinoNameTag = "Dolphin",    SpawnWeightMultiplier = 0.1F, OverrideSpawnLimitPercentage = true, SpawnLimitPercentage = 1.0F },
                new DinoSpawn { DinoNameTag = "Flyingant",  SpawnWeightMultiplier = 0.1F, OverrideSpawnLimitPercentage = true, SpawnLimitPercentage = 1.0F },                
                new DinoSpawn { DinoNameTag = "Mammoth",    SpawnWeightMultiplier = 0.1F, OverrideSpawnLimitPercentage = true, SpawnLimitPercentage = 1.0F },
                new DinoSpawn { DinoNameTag = "Mega",       SpawnWeightMultiplier = 0.1F, OverrideSpawnLimitPercentage = true, SpawnLimitPercentage = 1.0F },
                new DinoSpawn { DinoNameTag = "Para",       SpawnWeightMultiplier = 0.1F, OverrideSpawnLimitPercentage = true, SpawnLimitPercentage = 1.0F },
                new DinoSpawn { DinoNameTag = "Phiomia",    SpawnWeightMultiplier = 0.1F, OverrideSpawnLimitPercentage = true, SpawnLimitPercentage = 1.0F },
                new DinoSpawn { DinoNameTag = "Piranha",    SpawnWeightMultiplier = 0.1F, OverrideSpawnLimitPercentage = true, SpawnLimitPercentage = 1.0F },
                new DinoSpawn { DinoNameTag = "Plesiosaur", SpawnWeightMultiplier = 0.1F, OverrideSpawnLimitPercentage = true, SpawnLimitPercentage = 1.0F },
                new DinoSpawn { DinoNameTag = "Ptera",      SpawnWeightMultiplier = 0.1F, OverrideSpawnLimitPercentage = true, SpawnLimitPercentage = 1.0F },
                new DinoSpawn { DinoNameTag = "Raptor",     SpawnWeightMultiplier = 0.1F, OverrideSpawnLimitPercentage = true, SpawnLimitPercentage = 1.0F },
                new DinoSpawn { DinoNameTag = "Rex",        SpawnWeightMultiplier = 0.1F, OverrideSpawnLimitPercentage = true, SpawnLimitPercentage = 1.0F },
                new DinoSpawn { DinoNameTag = "Sabertooth", SpawnWeightMultiplier = 0.1F, OverrideSpawnLimitPercentage = true, SpawnLimitPercentage = 1.0F },
                new DinoSpawn { DinoNameTag = "Sarco",      SpawnWeightMultiplier = 0.1F, OverrideSpawnLimitPercentage = true, SpawnLimitPercentage = 1.0F },
                new DinoSpawn { DinoNameTag = "Scorpion",   SpawnWeightMultiplier = 0.1F, OverrideSpawnLimitPercentage = true, SpawnLimitPercentage = 1.0F },
                new DinoSpawn { DinoNameTag = "Stego",      SpawnWeightMultiplier = 0.1F, OverrideSpawnLimitPercentage = true, SpawnLimitPercentage = 1.0F },
                new DinoSpawn { DinoNameTag = "Spino",      SpawnWeightMultiplier = 0.1F, OverrideSpawnLimitPercentage = true, SpawnLimitPercentage = 1.0F },
                new DinoSpawn { DinoNameTag = "Spider",     SpawnWeightMultiplier = 0.1F, OverrideSpawnLimitPercentage = true, SpawnLimitPercentage = 1.0F },
                new DinoSpawn { DinoNameTag = "Titanboa",   SpawnWeightMultiplier = 0.1F, OverrideSpawnLimitPercentage = true, SpawnLimitPercentage = 1.0F },
                new DinoSpawn { DinoNameTag = "Trike",      SpawnWeightMultiplier = 0.1F, OverrideSpawnLimitPercentage = true, SpawnLimitPercentage = 1.0F },
                new DinoSpawn { DinoNameTag = "Turtle",     SpawnWeightMultiplier = 0.1F, OverrideSpawnLimitPercentage = true, SpawnLimitPercentage = 1.0F }
            };

        public static IEnumerable<DinoSpawn> DinoSpawns => dinoSpawns.Select(d => d.Duplicate<DinoSpawn>());

        private static readonly ClassMultiplier[] tamedDinoClassDamageMultipliers = new ClassMultiplier[]
        {
            new ClassMultiplier { ClassName="Ankylo_Character_BP_C", Multiplier = 1.0f },
            new ClassMultiplier { ClassName="Ant_Character_BP_C", Multiplier = 1.0f },
            new ClassMultiplier { ClassName="FlyingAnt_Character_BP_C", Multiplier = 1.0f },
            new ClassMultiplier { ClassName="Argent_Character_BP_C", Multiplier = 1.0f },
            new ClassMultiplier { ClassName="Bat_Character_BP_C", Multiplier = 1.0f },
            new ClassMultiplier { ClassName="BoaFrill_Character_BP_C", Multiplier = 1.0f },
            new ClassMultiplier { ClassName="Carno_Character_BP_C", Multiplier = 1.0f },
            new ClassMultiplier { ClassName="Coel_Character_BP_C", Multiplier = 1.0f },
            new ClassMultiplier { ClassName="Dilo_Character_BP_C", Multiplier = 1.0f },
            new ClassMultiplier { ClassName="Dimorph_Character_BP_C", Multiplier = 1.0f },
            new ClassMultiplier { ClassName="Dodo_Character_BP_C", Multiplier = 1.0f },
            new ClassMultiplier { ClassName="Dolphin_Character_BP_C", Multiplier = 1.0f },
            new ClassMultiplier { ClassName="Mammoth_Character_BP_C", Multiplier = 1.0f },
            new ClassMultiplier { ClassName="Megalodon_Character_BP_C", Multiplier = 1.0f },
            new ClassMultiplier { ClassName="Para_Character_BP_C", Multiplier = 1.0f },
            new ClassMultiplier { ClassName="Phiomia_Character_BP_C", Multiplier = 1.0f },
            new ClassMultiplier { ClassName="Piranha_Character_BP_C", Multiplier = 1.0f },
            new ClassMultiplier { ClassName="Plesiosaur_Character_BP_C", Multiplier = 1.0f },
            new ClassMultiplier { ClassName="Ptero_Character_BP_C", Multiplier = 1.0f },
            new ClassMultiplier { ClassName="Ptero_Character_BP_C", Multiplier = 1.0f },
            new ClassMultiplier { ClassName="Raptor_Character_BP_C", Multiplier = 1.0f },
            new ClassMultiplier { ClassName="Stego_Character_BP_C", Multiplier = 1.0f },
            new ClassMultiplier { ClassName="Rex_Character_BP_C", Multiplier = 1.0f },
            new ClassMultiplier { ClassName="Saber_Character_BP_C", Multiplier = 1.0f },
            new ClassMultiplier { ClassName="Sarco_Character_BP_C", Multiplier = 1.0f },
            new ClassMultiplier { ClassName="Sauropod_Character_BP_C", Multiplier = 1.0f },
            new ClassMultiplier { ClassName="Scorpion_Character_BP_C", Multiplier = 1.0f },
            new ClassMultiplier { ClassName="SpiderL_Character_BP_C", Multiplier = 1.0f },
            new ClassMultiplier { ClassName="SpiderS_Character_BP_C", Multiplier = 1.0f },
            new ClassMultiplier { ClassName="Spino_Character_BP_C", Multiplier = 1.0f },
            new ClassMultiplier { ClassName="Stego_Character_BP_C", Multiplier = 1.0f },
            new ClassMultiplier { ClassName="Trike_Character_BP_C", Multiplier = 1.0f },
            new ClassMultiplier { ClassName="Turtle_Character_BP_C", Multiplier = 1.0f }
        };

        public static IEnumerable<ClassMultiplier> TamedDinoClassDamageMultipliers => tamedDinoClassDamageMultipliers.Select(d => d.Duplicate<ClassMultiplier>());
       
        private static readonly Level[] levelProgression = new Level[]
            {             
                new Level {XPRequired=5	    , EngramPoints=8  },
                new Level {XPRequired=20	, EngramPoints=8  },
                new Level {XPRequired=40	, EngramPoints=8  },
                new Level {XPRequired=70	, EngramPoints=8  },
                new Level {XPRequired=120	, EngramPoints=8  },
                new Level {XPRequired=190	, EngramPoints=8  },
                new Level {XPRequired=270	, EngramPoints=8  },
                new Level {XPRequired=360	, EngramPoints=8  },
                new Level {XPRequired=450	, EngramPoints=12 },
                new Level {XPRequired=550	, EngramPoints=12 },
                new Level {XPRequired=660	, EngramPoints=12 },
                new Level {XPRequired=780	, EngramPoints=12 },
                new Level {XPRequired=910	, EngramPoints=12 },
                new Level {XPRequired=1050	, EngramPoints=12 },
                new Level {XPRequired=1200	, EngramPoints=12 },
                new Level {XPRequired=1360	, EngramPoints=12 },
                new Level {XPRequired=1530	, EngramPoints=12 },
                new Level {XPRequired=1710	, EngramPoints=12 },
                new Level {XPRequired=1900	, EngramPoints=16 },
                new Level {XPRequired=2100	, EngramPoints=16 },
                new Level {XPRequired=2310	, EngramPoints=16 },
                new Level {XPRequired=2530	, EngramPoints=16 },
                new Level {XPRequired=2760	, EngramPoints=16 },
                new Level {XPRequired=3000	, EngramPoints=16 },
                new Level {XPRequired=3250	, EngramPoints=16 },
                new Level {XPRequired=3510	, EngramPoints=16 },
                new Level {XPRequired=3780	, EngramPoints=16 },
                new Level {XPRequired=4060	, EngramPoints=16 },
                new Level {XPRequired=4350	, EngramPoints=20 },
                new Level {XPRequired=4650	, EngramPoints=20 },
                new Level {XPRequired=4960	, EngramPoints=20 },
                new Level {XPRequired=5280	, EngramPoints=20 },
                new Level {XPRequired=5610	, EngramPoints=20 },
                new Level {XPRequired=5950	, EngramPoints=20 },
                new Level {XPRequired=6300	, EngramPoints=20 },
                new Level {XPRequired=6660	, EngramPoints=20 },
                new Level {XPRequired=7030	, EngramPoints=20 },
                new Level {XPRequired=7410	, EngramPoints=20 },
                new Level {XPRequired=7800	, EngramPoints=24 },
                new Level {XPRequired=8200	, EngramPoints=24 },
                new Level {XPRequired=8610	, EngramPoints=24 },
                new Level {XPRequired=9030	, EngramPoints=24 },
                new Level {XPRequired=9460	, EngramPoints=24 },
                new Level {XPRequired=9900	, EngramPoints=24 },
                new Level {XPRequired=10350	, EngramPoints=24 },
                new Level {XPRequired=10810	, EngramPoints=24 },
                new Level {XPRequired=11280	, EngramPoints=24 },
                new Level {XPRequired=11760	, EngramPoints=24 },
                new Level {XPRequired=12250	, EngramPoints=28 },
                new Level {XPRequired=12750	, EngramPoints=28 },
                new Level {XPRequired=13260	, EngramPoints=28 },
                new Level {XPRequired=13780	, EngramPoints=28 },
                new Level {XPRequired=14310	, EngramPoints=28 },
                new Level {XPRequired=14850	, EngramPoints=28 },
                new Level {XPRequired=15400	, EngramPoints=28 },
                new Level {XPRequired=15960	, EngramPoints=28 },
                new Level {XPRequired=16530	, EngramPoints=28 },
                new Level {XPRequired=17110	, EngramPoints=28 },
                new Level {XPRequired=17700	, EngramPoints=28 },
                new Level {XPRequired=18850	, EngramPoints=28 },
                new Level {XPRequired=21078	, EngramPoints=28 },
                new Level {XPRequired=22448	, EngramPoints=28 },
                new Level {XPRequired=23908	, EngramPoints=28 },
                new Level {XPRequired=25462	, EngramPoints=28 },
                new Level {XPRequired=27498	, EngramPoints=28 },
                new Level {XPRequired=30248	, EngramPoints=28 },
                new Level {XPRequired=32043	, EngramPoints=28 },
                new Level {XPRequired=34148	, EngramPoints=28 },
                new Level {XPRequired=36254	, EngramPoints=28 },
                new Level {XPRequired=38359	, EngramPoints=28 },
                new Level {XPRequired=40465	, EngramPoints=28 },
                new Level {XPRequired=42571	, EngramPoints=28 },
                new Level {XPRequired=44676	, EngramPoints=28 },
                new Level {XPRequired=46782	, EngramPoints=28 },
                new Level {XPRequired=48887	, EngramPoints=28 },
                new Level {XPRequired=50993	, EngramPoints=28 },
                new Level {XPRequired=53099	, EngramPoints=28 },
                new Level {XPRequired=55204	, EngramPoints=28 },
                new Level {XPRequired=57310	, EngramPoints=31 },
                new Level {XPRequired=59415	, EngramPoints=31 },
                new Level {XPRequired=61521	, EngramPoints=31 },
                new Level {XPRequired=63627	, EngramPoints=31 },
                new Level {XPRequired=65732	, EngramPoints=31 },
                new Level {XPRequired=67838	, EngramPoints=31 },
                new Level {XPRequired=69943	, EngramPoints=31 },
                new Level {XPRequired=72049	, EngramPoints=31 },
                new Level {XPRequired=74155	, EngramPoints=31 },
                new Level {XPRequired=76260	, EngramPoints=31 },
                new Level {XPRequired=78366	, EngramPoints=33 },
                new Level {XPRequired=80471	, EngramPoints=33 },
                new Level {XPRequired=82577	, EngramPoints=33 },
                new Level {XPRequired=84683	, EngramPoints=33 },
                new Level {XPRequired=86788	, EngramPoints=33 },
                new Level {XPRequired=88894	, EngramPoints=33 },
                new Level {XPRequired=90999	, EngramPoints=33 },
                new Level {XPRequired=93105	, EngramPoints=33 },
                new Level {XPRequired=95211	, EngramPoints=33 },
                new Level {XPRequired=97316	, EngramPoints=33 },
                new Level {XPRequired=99422	, EngramPoints=33 },
            };

        public static IEnumerable<Level> LevelProgression => levelProgression.Select(l => l.Duplicate());
    }
}
