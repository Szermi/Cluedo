using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Talking : MonoBehaviour
{
    public string personName;

    private HeroController player;
    private Text text;
    private bool inside;
    private bool talking;

    public GameObject textInteraction;
    public GameObject textConvo1;
    public GameObject textConvo2;
    public GameObject textConvo3;

    public Text Interaction;
    public Text Convo1;
    public Text Convo2;
    public Text Convo3;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Hero").GetComponent<HeroController>();
        text = GameObject.Find("TextPeople").GetComponent<Text>();
        inside = false;
        talking = false;

        Interaction = textInteraction.GetComponent<Text>();
        Convo1 = textConvo1.GetComponent<Text>();
        Convo2 = textConvo2.GetComponent<Text>();
        Convo3 = textConvo3.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Ludzie: " + player.peopleList.Count + "/6";

        if (Input.GetKeyDown("f") && inside)
            Talk();

        if (Input.GetKeyDown("1") && talking)
            AskForItem();

        if (Input.GetKeyDown("2") && talking)
            AskForPlace();

        if (Input.GetKeyDown("3") && talking)
            AskForPerson();

        if (Input.GetKeyDown("return") && talking)
            StartConvo();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            textInteraction.SetActive(true);
            inside = true;
        }
    }

    void Talk()
    {
        talking = true;
        player.peopleList.Add(personName);

        StartConvo();
    }

    void StartConvo()
    {
        Convo1.text = "(1) Zapytaj o przedmiot";
        Convo2.text = "(2) Zapytaj o miejsce";
        Convo3.text = "(3) Zapytaj o osobę";

        textInteraction.SetActive(false);
        textConvo1.SetActive(true);
        textConvo2.SetActive(true);
        textConvo3.SetActive(true);
    }

    void AskForItem()
    {
        Clear();
        if (personName == "Pawelczak")
            Convo1.text = "To na pewno nie była lina.";
        if (personName == "Żółtowski")
            Convo1.text = "Jestem pewien, że nie użyto łopaty, byłoby widać ślady wgniecenia.";
        if (personName == "Pastorski")
            Convo1.text = "Na pewno nie użyto do tego butelki.";
        if (personName == "Karman")
            Convo1.text = "Na nożu nie ma zapachu krwi, zawsze bym to wyczuł, gdyby go do tego użyto.";
        if (personName == "Zieliński")
            Convo1.text = "Na pewno nie użyto łopaty.";
        if (personName == "Bartoszak")
            Convo1.text = "Na pewno nie użyto siekiery, bo ja jej używałem.";

        Convo2.text = "Naciśnij enter, aby kontynuować.";

        textConvo1.SetActive(true);
        textConvo2.SetActive(true);
    }

    void AskForPlace()
    {
        Clear();
        if (personName == "Pawelczak")
            Convo1.text = "Poszedłem do opuszczonego domu, nic tam się nie działo";
        if (personName == "Żółtowski")
            Convo1.text = "Byłem wczoraj popływać w jeziorze, nic dziwnego tam nie widziałem.";
        if (personName == "Pastorski")
            Convo1.text = "Na pewno nic się nie wydarzyło wczoraj przy studni, chodziłem kilka razy po wodę.";
        if (personName == "Karman")
            Convo1.text = "Byłem wczoraj na grobie zmarłego brata, błoga cisza.";
        if (personName == "Zieliński")
            Convo1.text = "Byłem wczoraj na rybach, nic się nie działo.";
        if (personName == "Bartoszak")
            Convo1.text = "Siedziałem cały dzień w szopie, więc to na pewno nie tam.";

        Convo2.text = "Naciśnij enter, aby kontynuować.";

        textConvo1.SetActive(true);
        textConvo2.SetActive(true);
    }

    void AskForPerson()
    {
        Clear();
        if (personName == "Pawelczak")
            Convo1.text = "To na pewno nie Żółtowski, widziałem go wczoraj.";
        if (personName == "Żółtowski")
            Convo1.text = "To nie może być Zieliński.";
        if (personName == "Pastorski")
            Convo1.text = "To na pewno nie Bartoszak.";
        if (personName == "Karman")
            Convo1.text = "To na pewno nie Pawelczak ani Bartoszak.";
        if (personName == "Zieliński")
            Convo1.text = "Jestem święcie przekonany, że nie zrobił tego Karman.";
        if (personName == "Bartoszak")
            Convo1.text = "Dam sobie rękę uciąć, że to nie był Pawelczak";

        Convo2.text = "Naciśnij enter, aby kontynuować.";

        textConvo1.SetActive(true);
        textConvo2.SetActive(true);
    }

    void Clear()
    {
        textInteraction.SetActive(false);
        textConvo1.SetActive(false);
        textConvo2.SetActive(false);
        textConvo3.SetActive(false);
    }

    void OnTriggerExit(Collider other)
    {
        inside = false;
        talking = false;
        Clear();
    }
}
