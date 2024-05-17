using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class controlquest : MonoBehaviour
{
    [SerializeField] GameObject AppreciationUI;
    [System.Serializable]
    public class Soals
    {
        [System.Serializable]
        public class ElementSoals //nomor 1 dst
        {
            public Sprite spriteSoal;
            public Sprite [] spriteJawabans;

            public int kunciJawaban; //kunci jawaban
        }
        public ElementSoals elementSoals;

    }
    public Soals[] soals;

   [Header ("Random Index")]
    //Random Index
    public int[] indexRandomSoal;
    public int[] indexRandomJawaban;
    public int totalSoal;
    public int urutanSoal;
    int jawabanBenar;

    [Header("UI soal dan jawaban")]
    public Image imageSoal;
    public Image[] imageJawabans;


    void Start()
    {
        GenerateIndexRandomSoal();
        GenerateIndexRandomJawaban();

        GenerateSoal();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonJawabans(int indexJawaban)
    {
        if (indexRandomJawaban[indexJawaban] == jawabanBenar){
            Debug.Log("benar");

            if (urutanSoal < totalSoal - 1 )
            {
                urutanSoal += 1;
                GenerateIndexRandomJawaban();// Mengacak posisi jawaban lagi
                GenerateSoal();
            }
           else
            {
                StartCoroutine(ChangeScene());
            }
        }
        else
        {
            Debug.Log("salah");
        }
    }

    void GenerateIndexRandomJawaban()
    {
        indexRandomJawaban = new int[4];
        for (int i= 0; i < indexRandomJawaban.Length; i++)
        {
            indexRandomJawaban[i] = i;
        }
        for (int i= 0; i < indexRandomJawaban.Length; i++)
        {
            int a = indexRandomJawaban[i];
            int b = Random.Range(0, indexRandomJawaban.Length);
            indexRandomJawaban[i] = indexRandomJawaban[b];
            indexRandomJawaban[b] = a;
        }
    }

    void GenerateIndexRandomSoal()
    {
        indexRandomSoal = new int[soals.Length];
        for (int i = 0; i < indexRandomSoal.Length; i++)
        {
            indexRandomSoal[i] = i;
        }

            for (int i=0; i < indexRandomSoal.Length; i++)
        {
            int a = indexRandomSoal[i];
            int b = Random.Range(0, indexRandomSoal.Length);
            indexRandomSoal[i] = indexRandomSoal[b];
            indexRandomSoal[b] = a;

        }
    }

    void GenerateSoal()
    {
        //Update soal
        imageSoal.sprite = soals[indexRandomSoal[urutanSoal]].elementSoals.spriteSoal;

        //Update jawabn
        for (int i=0; i < 4; i++)
        {
            imageJawabans[i].sprite = soals[indexRandomSoal[urutanSoal]].elementSoals.spriteJawabans[indexRandomJawaban[i]];
        }

        //jawaban Benar
        jawabanBenar = soals[indexRandomSoal[urutanSoal]].elementSoals.kunciJawaban;

    }

    IEnumerator ChangeScene()
    {
        AppreciationUI.SetActive(true);
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("Bermain");
        Debug.Log("Finish Game");
    }

    

   
}