using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrinterMenager : MonoBehaviour
{
    public List<GameObject> paperList = new List<GameObject>();
    public GameObject paperPrefab;
    public Transform exitPoint;
    bool isWorking;
    void Start()
    {
        StartCoroutine(PrintPaper());

    }

    IEnumerator PrintPaper()
    {
        while(true)
        {
            float paperCount = paperList.Count;
            if (isWorking == true)
            {                
                GameObject temp = Instantiate(paperPrefab);
                temp.transform.position = new Vector3(exitPoint.position.x, paperCount / 20, exitPoint.position.z);
                paperList.Add(temp);
               
            }            
            if (paperList.Count >= 30)
            {
                isWorking = false;

            }
            else
                isWorking = true;
            yield return new WaitForSeconds(0.1f);

        }

       
    }
}
