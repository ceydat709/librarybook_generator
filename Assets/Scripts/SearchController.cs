using UnityEngine;
using TMPro;

public class SearchController : MonoBehaviour
{
    public TMP_InputField searchInput; 
    public GameObject[] gameObjects;

    public void Search()
    {
        string searchTerm = searchInput.text.ToLower(); //get search term

        //iterate through array
        foreach (GameObject obj in gameObjects)
        {
            //check name of current obj
            if (obj.name.ToLower().Contains(searchTerm))
            {
                obj.SetActive(true);//activate obj
            }
            else
            {
                obj.SetActive(false);//deactivate obj
            }
        }
    }
}
