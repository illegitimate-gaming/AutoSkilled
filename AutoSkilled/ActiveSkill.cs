using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeta;
using Zeta.CommonBot;
using Zeta.Internals.Actors;

namespace AutoSkilled {
    public class ActiveSkill : Skill {
        public HotbarSlot HotbarSlot { get; set; }

        private Dictionary<string, HotbarSlot> ActiveSkillSlotDict;

        public ActiveSkill() : base() {
            ActiveSkillSlotDict = new Dictionary<string, HotbarSlot>();
            // Skill Slots
            ActiveSkillSlotDict.Add("L", HotbarSlot.HotbarMouseLeft);
            ActiveSkillSlotDict.Add("R", HotbarSlot.HotbarMouseRight);
            ActiveSkillSlotDict.Add("1", HotbarSlot.HotbarSlot1);
            ActiveSkillSlotDict.Add("2", HotbarSlot.HotbarSlot2);
            ActiveSkillSlotDict.Add("3", HotbarSlot.HotbarSlot3);
            ActiveSkillSlotDict.Add("4", HotbarSlot.HotbarSlot4);
        }

        public override bool Activate() {
            // Get the current Skill in the hotbar slot we want to use
            SNOPower CurrentlyEquippedSkillInHotbarSlot = ZetaDia.CPlayer.GetPowerForSlot(this.HotbarSlot);
            // Check if Skill in slot is off cooldown, out of resource, or slot is empty so we can switch it
            PowerManager.CanCastFlags CastFlag = PowerManager.CanCastFlags.None;
            bool WasSet = false;
            bool OffCooldown = PowerManager.CanCast(CurrentlyEquippedSkillInHotbarSlot, out CastFlag);
            if (OffCooldown || CastFlag == PowerManager.CanCastFlags.PowerNotEnoughResource || CastFlag == PowerManager.CanCastFlags.PowerUnusableGeneric || CurrentlyEquippedSkillInHotbarSlot == SNOPower.None) {
                // Set the skill
                ZetaDia.Me.SetActiveSkill(this.Power, this.RuneId, this.HotbarSlot);
                ZetaDia.Actors.Update();
                // Check to see if it actually was set
                if (ZetaDia.CPlayer.GetPowerForSlot(this.HotbarSlot) == this.Power && ZetaDia.CPlayer.GetRuneIndexForSlot(this.HotbarSlot) == this.RuneId) {
                    WasSet = true;
                }
            }
            return WasSet;
        }

        public override void SetSlotByString(string SlotString) {
            this.HotbarSlot = ActiveSkillSlotDict[SlotString];
        }
    }
}
