using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMDB.Data
{
    public class PlayerData
    {
        public string Name { get; set; }
        public string Account { get; set; }
        public string Class { get; set; }
        public int Health { get; set; }
        public int Mana { get; set; }
        public int Strenght { get; set; }
        public string Constitution { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }
        public long Experience { get; set; }
        public long GameCurrency { get; set; }
        public long StoreCurrency { get; set; }
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }
        public ICollection<PlayerSkillData> Skills { get; set; }
        public ICollection<PlayerEffectData> Effects { get; set; }
        public ICollection<PlayerQuestData> Quests { get; set; }
        public ICollection<PlayerInventoryData> Inventory { get; set; }
        public ICollection<PlayerEquipmentData> Equipment { get; set; }
    }
}
