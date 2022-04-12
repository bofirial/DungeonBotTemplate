using DungeonBotGame.Combat;
using DungeonBotGame.Foundation;

namespace MyDungeonBotAdventure.DungeonBots;

[DungeonBot("WarriorBot001")]
public partial class WarriorBot
{
    public IAction Action(ISensorComponent sensorComponent)
    {
        var enemy = sensorComponent.Enemies.First();

        return Attack(enemy);
    }
}