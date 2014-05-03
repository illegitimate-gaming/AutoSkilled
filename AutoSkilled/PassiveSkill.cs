using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeta;
using Zeta.Internals.Actors;

namespace AutoSkilled {
    public class PassiveSkill : Skill {
        public int PassiveSlot { get; set; }

        private Dictionary<string, int> PassiveSkillSlotDict;

        public PassiveSkill() : base() {
            PassiveSkillSlotDict = new Dictionary<string, int>();
            PassiveSkillSlotDict.Add("P1", 0);
            PassiveSkillSlotDict.Add("P2", 1);
            PassiveSkillSlotDict.Add("P3", 2);
        }

        public override bool Activate() {
            SNOPower[] CurrentPassives = new SNOPower[3];
            int i = 0;
            // Read current passives and store them in array
            foreach (SNOPower currentlySetPassive in ZetaDia.CPlayer.PassiveSkills) {
                if(currentlySetPassive == null) {
                    CurrentPassives[i] = SNOPower.None;
                } else {
                    CurrentPassives[i] = currentlySetPassive;
                }
                i++;
            }
            CurrentPassives[this.PassiveSlot] = this.Power;
            ZetaDia.Me.SetTraits(CurrentPassives[0], CurrentPassives[1], CurrentPassives[2]);
            ZetaDia.Actors.Update();
            IEnumerable PassivesSet = ZetaDia.CPlayer.PassiveSkills;
            bool PassiveSkillWasSet = false;
            foreach (SNOPower setPassiveSkill in PassivesSet) {
                if (setPassiveSkill == this.Power) {
                    PassiveSkillWasSet = true;
                }
            }

            return PassiveSkillWasSet;
        }

        public override void SetSlotByString(string SlotString) {
            this.PassiveSlot = PassiveSkillSlotDict[SlotString];
        }
    }
}
