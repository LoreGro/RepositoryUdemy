using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurriculumVitae : MonoBehaviour
{
    public string MyName = "Lorenzo Grossi";
    public float Born = 6.1987f;
    public string diploma = " Game Design Certificate";
    public string MySite = "https://lgrossi87.wixsite.com/portfolio";
    public float Phone = 328.6929164f;
    public string Address = " Via Piave 13/3, 21028, Travedona Monate (VA) – IT ";



    void Start()
    {

        //Let me introduce myself with some basic informations

        print("My name is " + MyName);
        print("and I was born the fourth of  " + Born);
        
        int IstitutoVolta = 2022;
        print(IstitutoVolta  +  diploma);

        Softwares();

        EducationAndTraining();

        OtherWorkExperiences();

        MyPurpose();

    }

    
    void Update()
    {
        // Looking for new experiences 
    }

    void Softwares()
    {
        print("With the " + diploma  + " achieved at Istituto Volta" );
        print("I am able to use the following softwares:");
        print("Pixologic ZBrush");
        print("Maya 3D");
        print("Substance Painter");
        print("Unity 3D");
    }

    void EducationAndTraining()

    {
        //int Scientific_HighSchool_Gavirate = 2006;
        int University_Of_Milan = 2011;
        int IULM_Milan = 2013;

        print("In" + University_Of_Milan  + " I graduated in Political Sciences");

        print("after a year abroad, in " + IULM_Milan + " I achieved a Master Degree in Social, Political and Institutional Communication");


    }


    void OtherWorkExperiences()

    {
        
        int Conforama_SpA = 2007;
        int Moonwater_Srl = 2010;
        int Mentis_Media_NL = 2011;
        int Boschetto_Holiday_Srl = 2012;
        int Tangenziale_Esterna_SpA = 2013;

        print("In " + Conforama_SpA + "I worked for two years as a cashier and storekeeper for paying my studying and my trips");
        print("In " + Moonwater_Srl + "I worked for a year in a call center. This type of job helped me to improve my self control and  my dialectic towards problematic situations");
        print("In " + Mentis_Media_NL + " I had an experience of one year abroad, in Holland, as a employer assistant, event planner, PR, customer service and driver");
        print("In " + Boschetto_Holiday_Srl + "I worked, from spring to autumn, in the touristic field as a event planner, customer service and international customer relations, event planner, front and back office, night watchman");



        print("Since" + Tangenziale_Esterna_SpA + " I am working for the Administration Department of one of the most important Highway Corporation operating within the Metropolitan Area of Milan");
        print("At the moment, my daily job is to liase with all the departments of the company, mostly being responsible for purchasing management and customer service supervision activites");



    }

    void MyPurpose()
    {
        print("I would like to test myself in a different context, learn new activities and enrich both my professional and personal life");

    }



}
