using UnityEngine;
using UnityEngine.UI;

public class CategoryButton : MonoBehaviour
{
    public GameObject[] bookSquares; // Array of book square GameObjects

    //index of the books
    public int categoryIndex; 

    public void OnClick()
    {
        //deactivate books
        foreach (GameObject square in bookSquares)
        {
            square.SetActive(false);
        }

        //check index = 0
        if (categoryIndex == 0)
        {
            //activate the specific book  associated with category index 0
            if (bookSquares.Length > 0)
            {
                bookSquares[0].SetActive(true);
            }
        }

        else if (categoryIndex == 1)
        {
       
            if (bookSquares.Length > 0)
            {
                bookSquares[1].SetActive(true);
            }
        }
        else if(categoryIndex == 2)
        {

            if (bookSquares.Length > 0)
            {
                bookSquares[2].SetActive(true);
            }
        }
        else if (categoryIndex == 3)
        {

            if (bookSquares.Length > 0)
            {
                bookSquares[3].SetActive(true);
            }
        }
        else if (categoryIndex == 4)
        {

            if (bookSquares.Length > 0)
            {
                bookSquares[4].SetActive(true);
            }
        }
        else if (categoryIndex == 5)
        {

            if (bookSquares.Length > 0)
            {
                bookSquares[0].SetActive(true);
                bookSquares[1].SetActive(true);
                bookSquares[2].SetActive(true);
                bookSquares[3].SetActive(true);
                bookSquares[4].SetActive(true);
            }
        }
        else if (categoryIndex > 0 && categoryIndex < bookSquares.Length)
        {
            //activate the book  associated with the category index
            bookSquares[categoryIndex].SetActive(true);
        }
    }
}
