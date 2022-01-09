using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
 public struct Datatag
    {
        public String kerdes;
        public String valasz1;
        public String valasz2;
        public String valasz3;
        public String valasz4;
        public bool isused;
        public int topicID;
    }
public class QuestionScript : MonoBehaviour
{
    public List<Datatag> FinData;

    public GameObject chest;
	public Animator animator;
	public GameObject question;
	public Text txt;
	public Text answ1;
	public Text answ2;
	public Text answ3;
	public Text answ4;
	private int CorrectAnswer= -2;
	private int Answer=-1;
	public GameObject Button1;
	public GameObject Button2;
	public GameObject Button3;
	public GameObject Button4;
    public Button Exit;
    public Text Money;
    private bool answered = false;
    public bool goodanswer = false;

    public  List<Datatag> getData()
    {
        return FinData;
    }
    void Start()
    {
        txt.text="kfessdfiusiliouf";
		answ1.text="1";
		answ2.text="2";
		answ3.text="3";
		answ4.text="4";



		Datatag kerdes1;
        kerdes1.kerdes = "Mit jelent a pro anno kifejezés?";
        kerdes1.valasz1 ="Évente";
        kerdes1.valasz2 = "Havonta";
        kerdes1.valasz3 = "Meghatározott idöközönként";
        kerdes1.valasz4 = "Évszázadonként";
        kerdes1.isused = false;
        kerdes1.topicID = 0;

        Datatag kerdes2;
        kerdes2.kerdes = "Mi az egyszeri kis összegü pénzösszeg elhelyezésének legbiztonságosabb módja?";
        kerdes2.valasz1 = "Banki betétszámla";
        kerdes2.valasz2 = "Részvények";
        kerdes2.valasz3 = "Értékpapírok";
        kerdes2.valasz4 = "Arany felvásárlás";
        kerdes2.isused = false;
        kerdes2.topicID = 0;

        Datatag kerdes3;
        kerdes3.kerdes = "Mit jelent hogy egy bankbetét változó kamatozású?";
        kerdes3.valasz1 = "A bank változtathatja a kamatlábot a futmaidö alatt";
        kerdes3.valasz2 = " Különbözö bankoknak a kamatai is különböznek";
        kerdes3.valasz3 = "Magad válaszhatod meg a kamatlábat";
        kerdes3.valasz4 = "A kamatláb emelkedni fog 1 év után";
        kerdes3.isused = false;
        kerdes3.topicID = 0;


        Datatag kerdes4;
        kerdes4.kerdes = "Mi a jövedelem?";
        kerdes4.valasz1 = "Rendelkezésre álló kereset (pl.: fizetés)";
        kerdes4.valasz2 = "Nyereség";
        kerdes4.valasz3 = "Befizetett rezsi, vagy törlesztöészlet";
        kerdes4.valasz4 = "Bankszámlák közötti átutalások";
        kerdes4.isused = false;
        kerdes4.topicID = 0;


         Datatag kerdes5;
        kerdes5.kerdes = "Mi jellemzö ha a folyószámlahitel nélküli betéti bankkártyád van?";
        kerdes5.valasz1 = "Nem lehet hegatív irányú az egyenleged";
        kerdes5.valasz2 = "Nem lehet hiteled";
        kerdes5.valasz3 = "Nincs különbség a kártyatípusok között";
        kerdes5.valasz4 = "Nem lehet pozitív irányú az egyenleged";
        kerdes5.isused = false;
        kerdes5.topicID = 1;

        Datatag kerdes6;
        kerdes6.kerdes = "Mi jellemzi a hitelkártya használatot?";
        kerdes6.valasz1 = "A vásárlást követö 4-6 hét elteltével vonják le az összeget";
        kerdes6.valasz2 = "A bank dönti el, hogy mikor zárolja a vásárlás összegét";
        kerdes6.valasz3 = "Akkor választható, ha a vásárlás összegét zárolták";
        kerdes6.valasz4 = "A gazdagok speciális bankkártyája";
        kerdes6.isused = false;
        kerdes6.topicID = 1;

        Datatag kerdes7;
        kerdes7.kerdes = "Mi az egyetlen bankkártya, ami 18 éven aluliak számára elérhetö";
        kerdes7.valasz1 = "Betéti kártya(hitelkeret nélkül)";
        kerdes7.valasz2 = "Hitelkártya";
        kerdes7.valasz3 = "SZÉP-kártya";
        kerdes7.valasz4 = "18 éven aluliaknak nem lehet bankkártyája";
        kerdes7.isused = false;
        kerdes7.topicID = 1;


        Datatag kerdes8;
        kerdes8.kerdes = "Melyik fizetöeszköz nem használható egy szupermarketben?";
        kerdes8.valasz1 = "Bitcoin";
        kerdes8.valasz2 = "Betéti kártya";
        kerdes8.valasz3 = "Hitelkártya";
        kerdes8.valasz4 = "Készpénz";
        kerdes8.isused = false;
        kerdes8.topicID = 1;


        Datatag kerdes9;
        kerdes9.kerdes = "Melyik az a fizetöeszköz, amelyik valójában kölcsön?";
        kerdes9.valasz1 = "Hitelkártya";
        kerdes9.valasz2 = "Hitel nélküli betéti kártya";
        kerdes9.valasz3 = "Jogosítvány";
        kerdes9.valasz4 = "Készpénz";
        kerdes9.isused = false;
        kerdes9.topicID = 1;

        Datatag kerdes10;
         kerdes10.kerdes = "Az alábbiak közül melyik NEM az európai pénzügyi intézmény?";
        kerdes10.valasz1 = "Európai Bankföderáció";
        kerdes10.valasz2 = "Európai Befektetési alap";
        kerdes10.valasz3 = "Európai Befektetési Bank";
        kerdes10.valasz4 = "Európai Központi Bank";
        kerdes10.isused = false;
        kerdes10.topicID = 2;


        Datatag kerdes11;
        kerdes11.kerdes = "Mi az Európai Központi Bank feladata";
        kerdes11.valasz1 = "Az euró megóvása az elértéktelenedéstöl";
        kerdes11.valasz2 = "Ha a bankok csödbe mennek, anyagi támogatást nyújt";
        kerdes11.valasz3 = "Az európai embereknek kedvezö kölcsön biztosítása";
        kerdes11.valasz4 = "A mezögazdasági vállalkozások anyagi támogatása";
        kerdes11.isused = false;
        kerdes11.topicID = 2;

        Datatag kerdes12;
        kerdes12.kerdes = "Az alábbiak közül melyik NEM létezö bevételi forrás az Európai Unió számára?";
        kerdes12.valasz1 = "Az EU polgárai által befizetett éves egyéni díj";
        kerdes12.valasz2 = "A tagállamok hozzájárulásai";
        kerdes12.valasz3 = "Az uniós jogokat megsértö vállalkozások pénzbírságai";
        kerdes12.valasz4 = "Az EU-n kívülröl származó termékek vámja";
        kerdes12.isused = false;
        kerdes12.topicID = 2;


        Datatag kerdes13;
        kerdes13.kerdes = "Megközelítöleg mennyi pénz költ el az Európai Unió évente";
        kerdes13.valasz1 = "Kb. 150 milliárd eurót";
        kerdes13.valasz2 = "Kb. 500 millió eurót";
        kerdes13.valasz3 = "Kb. 50 milliárd eurót";
        kerdes13.valasz4 = "Kb. 50 trillió eurót";
        kerdes13.isused = false;
        kerdes13.topicID = 2;

        /*
        Datatag kerdes4;
        kerdes4.kerdes = ;
        kerdes4.valasz1 = ;
        kerdes4.valasz2 = ;
        kerdes4.valasz3 = ;
        kerdes4.valasz4 = ;
        kerdes4.isused = false;
        kerdes4.topicID = 1;
        */

    FinData = new List<Datatag> (new Datatag[]{ kerdes1, kerdes2, kerdes3, kerdes4, kerdes5, kerdes6, kerdes7, kerdes8, kerdes9, kerdes10, kerdes11, kerdes12, kerdes13});
	SetUp(FinData);

    }
	private void Update(){
		if(Answer!=-1 && !answered){
			if(CheckAnswer()){
				if(CorrectAnswer==0){
					Button1.GetComponent<Image>().color = Color.green;
				}
				else if(CorrectAnswer==1){
					Button2.GetComponent<Image>().color = Color.green;
				}
				else if(CorrectAnswer==2){
					Button3.GetComponent<Image>().color = Color.green;
				}
				else if(CorrectAnswer==3){
					Button4.GetComponent<Image>().color = Color.green;
				}
                //animator.SetBool("Interact", true);
                globalStorage.Instance.points += 20;
                Debug.Log(globalStorage.Instance.points);
                Money.text = globalStorage.Instance.points.ToString();
            }
			else{
				//chest.GetComponent<Image>().color=Color.red;
				if(Answer==0){
					Button1.GetComponent<Image>().color = Color.red;
				}
				else if(Answer==1){
					Button2.GetComponent<Image>().color = Color.red;
				}
				else if(Answer==2){
					Button3.GetComponent<Image>().color = Color.red;
				}
				else if(Answer==3){
					Button4.GetComponent<Image>().color = Color.red;
				}
				//animator.SetBool("Interact",false);
			}

            if(globalStorage.Instance.isInterractingWithChest)
            {
                animator.SetBool("Interact", true);
                globalStorage.Instance.isInterractingWithChest = false;
            }
            
            Exit.gameObject.SetActive(true);
            //question.SetActive(false);
            Answer = -1;
            CorrectAnswer = -2;
            answered = true;
           

        }
	}
	public void Pressed1(){
		Answer=0;
	
	}
	public void Pressed2(){
		Answer=1;
	}
	public void Pressed3(){
		Answer=2;
	}
	public void Pressed4(){
		Answer=3;
	}
	public bool CheckAnswer(){
		if(Answer==CorrectAnswer){
			return true;
		}
		return false;
	}
	public void SetUp(List<Datatag> data){

    Exit.gameObject.SetActive(false);
        NewQuestion( data);


    }
    public void NewQuestion(List<Datatag> data) {
        goodanswer = false; ;

        answered = false;
        Button1.GetComponent<Image>().color = Color.white;
        Button2.GetComponent<Image>().color = Color.white;
        Button3.GetComponent<Image>().color = Color.white;
        Button4.GetComponent<Image>().color = Color.white;

        System.Random r = new System.Random();
        
        int rInt = r.Next(0, data.Count - 1);

        txt.text = data[rInt].kerdes;
        CorrectAnswer = r.Next(0, 4 - 1);
        Sorter(CorrectAnswer, data[rInt].valasz1);
        Debug.Log(data[rInt].valasz1 + CorrectAnswer);
        List<int> list = new List<int> { 0, 1, 2, 3 };
        Debug.Log(CorrectAnswer);

        list.Remove(list[CorrectAnswer]);
        int rnd;

        rnd = r.Next(0, list.Count - 1);
        Sorter(list[rnd], data[rInt].valasz2);
        list.Remove(list[rnd]);

        rnd = r.Next(0, list.Count - 1);
        Sorter(list[rnd], data[rInt].valasz3);
        list.Remove(list[rnd]);
        Debug.Log(rnd);
        Sorter(list[rnd], data[rInt].valasz4);
    }

    private void Sorter(int var,string valasz){
		if(var==0){
			answ1.text=valasz;
		}
		else if(var==1){
			answ2.text=valasz;
		}
		else if(var==2){
			answ3.text=valasz;
		}
		else if(var==3){
			answ4.text=valasz;

		}
	
	}
}
