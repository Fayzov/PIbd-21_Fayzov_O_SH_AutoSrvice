using System;

namespace AutoServiceApp.Enums;

[Flags]
public enum WorkCategory
{
    None = 0,
    Maintenance = 1,  // ТО
    EngineRepair = 2, // Ремонт двигателя
    BodyRepair = 4,   // Кузовной
    Electric = 8      // Электрика
}
