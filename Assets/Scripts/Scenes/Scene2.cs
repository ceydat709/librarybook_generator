// Scene1Script.cs (attached to a GameObject in Scene 1)
using UnityEngine;

public class Scene2 : MonoBehaviour
{
    public BookLoader bookLoader;

    void Start()
    {
        //load second book
        bookLoader.Initialize(1);
    }
}
