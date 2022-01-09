using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class kerdesbank : MonoBehaviour
{
    public GameObject cont;
    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        Datatag kerdes1;
        kerdes1.kerdes = "Mit jelent a pro anno kifejezés?";
        kerdes1.valasz1 = "Évente";
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
        kerdes4.valasz1 = "Rendelkezésre álló kereset(pl.: fizetés)";
        kerdes4.valasz2 = "Nyereség";
        kerdes4.valasz3 = "Befizetett rezsi, vagy törlesztörészlet";
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
        kerdes7.kerdes = "Mi az egyetlen bankkártya, ami 18 éven aluliak számára elérhetö?";
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
        kerdes11.valasz1 = "Az euró megóvása az elértéktelenedéstöl?";
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

        List<Datatag> FinData = new List<Datatag>(new Datatag[] { kerdes1, kerdes2, kerdes3, kerdes4, kerdes5, kerdes6, kerdes7, kerdes8, kerdes9, kerdes10, kerdes11, kerdes12, kerdes13 });

        /*
        int length = FinData.Count;
        cont.transform.localScale = new Vector3(cont.transform.localScale.x + (prefab.gameObject.transform.localScale.x + 2)*length, cont.transform.localScale.y, cont.transform.localScale.z);
        Vector3 nextSpawnLocation = cont.gameObject.transform.position;
        for (int i = 0; i < length; i++)
        {
            Vector3 prevPos = cont.transform.position;
            cont.transform.localScale = new Vector3(cont.transform.localScale.x + prefab.gameObject.transform.localScale.x + 2, cont.transform.localScale.y, cont.transform.localScale.z);
            cont.transform.position = prevPos;
            GameObject instance = Instantiate(prefab, nextSpawnLocation, Quaternion.identity);
            instance.gameObject.transform.GetChild(0).GetComponent<Text>().text = FinData[i].kerdes;
            instance.gameObject.transform.SetParent(cont.gameObject.transform);
            nextSpawnLocation -= new Vector3(prefab.gameObject.transform.localScale.x + 2, nextSpawnLocation.y, nextSpawnLocation.z);
        }
        */
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
