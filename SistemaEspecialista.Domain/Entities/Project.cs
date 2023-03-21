namespace SistemaEspecialista.Domain.Entities;

public class Project : Entity
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public List<Objective> Objectives { get; set; } = new();
    public List<Characteristic> Characteristics { get; set; } = new();
    public List<ObjectiveCharacteristic> ObjectiveCharacteristics { get; set; } = new();
    public List<Question> Questions { get; set; } = new();
}
