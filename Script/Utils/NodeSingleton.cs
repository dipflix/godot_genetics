using Godot;

namespace GeneticsMono.Script.Utils;

public partial class NodeSingleton<T> : Node where T : NodeSingleton<T>, new()
{
    private static T _instance;

    public static T Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new T();
            }

            return _instance;
        }
    }
}