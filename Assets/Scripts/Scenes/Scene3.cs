// Scene1Script.cs (attached to a GameObject in Scene 1)
using UnityEngine;

public class Scene3 : MonoBehaviour
{
    public BookLoader bookLoader;

    void Start()
    {
        //load third book
        bookLoader.Initialize(2);
    }
}
