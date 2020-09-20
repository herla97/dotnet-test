using System;
using donet_test.Models;

namespace donet_test.Dtos.Character
{
    public class UpdateCharacterDto
    {
        
        public Guid Id { get; set; }
        public string Name { get; set; } = "Frodo";
        public int HitPoints { get; set; } = 100;
        public int Strength  { get; set; } = 10;
        public int Defense { get; set; } = 10;
        public int Intelligence { get; set; } = 10;
        public RpgClass Class { get; set; } = RpgClass.Knight;
    }
}