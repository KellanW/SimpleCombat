namespace Assets.Scripts.Craft.Parts.Modifiers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Xml.Linq;
    using ModApi.Craft.Parts;
    using ModApi.Craft.Parts.Attributes;
    using UnityEngine;

    [Serializable]
    [DesignerPartModifier("Gun")]
    [PartModifierTypeId("SimpleCombat.Gun")]
    public class GunData : PartModifierData<GunScript>
    {
        [DesignerPropertySlider(Label = "Damage", MinValue = 1, MaxValue = 20)]
        public float damage = 1;
        [DesignerPropertySlider(Label = "Bullet Mass", MinValue = 0.01f, MaxValue = 0.2f)]
        public float bulletMass = 0.01f;
        [DesignerPropertySlider(Label = "Muzzle Velocity", MinValue = 200, MaxValue = 1000)]
        public float muzzleVelocity = 200;
        [DesignerPropertySlider(Label = "Rate of Fire", MinValue = 20, MaxValue = 200)]
        public float rateOfFire = 1;
        [DesignerPropertySlider(Label = "Bullet Dispersion", MinValue = 0, MaxValue = 1)]
        public float bulletDispersion = 0.1f;
        [DesignerPropertySlider(Label = "Recoil Multiplier",MinValue =0,MaxValue =1.2f)]
        public float recoil = 0;
    }
}