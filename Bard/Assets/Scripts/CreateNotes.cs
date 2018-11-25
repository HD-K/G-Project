using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class SongInfo
{
    public string[] Time;
    public string[] Type;
    public string[] Name;
}

public class CreateNotes : MonoBehaviour {

    public GameObject monsterPrefab;
    public GameObject Cube;
    public Transform[] points;
    public List<GameObject> monsterPool;
    public TextAsset textAsset;
    bool isGameOver = false;

    public List<string> noteData;
    public List<string> time;
    public static List<GameObject> noteObject;
    public static List<bool> noteCreate;
    float distance;
    public static float noteTime;
    Movement movement;
    SongInfo type = new SongInfo();
    Vector3 position;

    // Use this for initialization
    void Start()
    {
        movement = GetComponent<Movement>();
        monsterPool = new List<GameObject>();
        points[0].transform.position = new Vector3(7.6f, -1.8f, -0.5f);
        points[1].transform.position = new Vector3(7.6f, -2.25f, -0.5f);

        noteData = new List<string>();
        noteCreate = new List<bool>();
      
        //타이밍값만 가지고 있는 노트/0초 노트? 어떠한 패턴 파일이든 동일하게 노트가 움직이는 시간을 같게?
        //인게임 씬 하나. 패턴마다 Music의 딜레이값을 바꾼다면 계속해서 바꿔야 한다.
        //
        TextAsset textAsset = (TextAsset)Resources.Load("Note(2)");

        StringReader sr = new StringReader(textAsset.text);

        // 먼저 한줄을 읽는다. 

        string source = sr.ReadLine();

        type.Type= source.Split('\t');                // 쉼표로 구분된 데이터들을 저장할 배열 (values[0]이면 첫번째 데이터 )


        while (source != null)
        {
            type.Time = source.Split('\t');
            time.Add(type.Time[0]);
            noteData.Add(source);

            type.Type = source.Split('\t');  // 쉼표로 구분한다. 저장시에 쉼표로 구분하여 저장하였다.
            source = sr.ReadLine();    // 한줄 읽는다.

            if (type.Type.Length == 0)

            {

                sr.Close();

                return;

            }
            noteCreate.Add(true);
            
        }

        for (int i = 0; i < noteData.Count; i++)
        {
            GameObject monster = (GameObject)Instantiate(monsterPrefab);
            monster.SetActive(false);
            monsterPool.Add(monster);

        }
        distance = Vector3.Distance(Cube.transform.position, points[0].transform.position);
        Debug.Log(distance);
    }

    private void FixedUpdate()
    {
        noteTime += Time.deltaTime;
        for (int i = 0; i < noteData.Count; i++)
        {
            if (noteData.Count <= i)
            {
                break;
            }

            if (noteTime <= (float.Parse(time[i]) / 1000)
                   && noteCreate[i] == true)
            {
                monsterPool[i].transform.position = NotePos(noteData[i][12].ToString());
                monsterPool[i].SetActive(true);
                if (i > 33)
                {
                    monsterPool[i].transform.position = NotePos(noteData[i][13].ToString());
                }

            }
            
        }
    }
    Vector3 NotePos(string name)
    {
        switch (name)
        {

            case "U":
                position = points[0].transform.position;
                break;

            case "D":
                position = points[1].transform.position;
                break;

        }
        //Debug.Log(name);
        return position;
    }

}
