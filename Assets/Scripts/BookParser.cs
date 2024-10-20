// BookLoader.cs (attached to a GameObject in each scene)
using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using TMPro;
using System.Collections.Generic;


public class BookLoader : MonoBehaviour
{
    //serialize data
    [System.Serializable]
    public class Book
    {
        public string id;
        public string title;
        public string category;
        public string description;
        public string image_url;
    }

    [System.Serializable]
    public class BookData
    {
        public Book[] books;
    }

    private List<Book> allBooks = new List<Book>();

    public TextMeshProUGUI titleText;
    public TextMeshProUGUI categoryText;
    public TextMeshProUGUI descriptionText;
    public RawImage bookImage;

    private int currentBookIndex = 0;

    public void Initialize(int bookIndex)
    {
        currentBookIndex = bookIndex;
        StartCoroutine(FetchBooksData());
    }

    IEnumerator FetchBooksData()
    {
        string url = "http://localhost/phpcodes/FetchBooks.php";
        UnityWebRequest www = UnityWebRequest.Get(url);

        yield return www.SendWebRequest();

        if (www.result != UnityWebRequest.Result.Success)
        {
            Debug.LogError(www.error);
        }
        else
        {
            //parse data
            string json = www.downloadHandler.text;
            Debug.Log("JSON data received: " + json);

            //deserialize data
            BookData bookData = JsonUtility.FromJson<BookData>("{\"books\":" + json + "}");

            //store books in a list
            allBooks.AddRange(bookData.books);

            //display info of the current book
            DisplayBookInfo(allBooks[currentBookIndex]);
        }
    }


    void DisplayBookInfo(Book book)
    {
        //display book info
        titleText.text = book.title;
        categoryText.text = book.category;
        descriptionText.text = book.description;

        //load and display book
        StartCoroutine(LoadBookImage(book.image_url));
    }

    IEnumerator LoadBookImage(string imageUrl)
    {
        UnityWebRequest www = UnityWebRequestTexture.GetTexture(imageUrl);
        yield return www.SendWebRequest();

        if (www.result != UnityWebRequest.Result.Success)
        {
            Debug.LogError(www.error);
        }
        else
        {
            Texture2D texture = ((DownloadHandlerTexture)www.downloadHandler).texture;
            bookImage.texture = texture;
        }
    }
}
