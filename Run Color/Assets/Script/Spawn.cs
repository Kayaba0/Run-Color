using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

    float x;
    float y;
    float appX;
    float appY;
    float appX1;
    float appY1;
    Vector2 v = new Vector2(0,0);

    private string color;
    public Sprite Blue;
    public Sprite Green;
    public Sprite Orange;
    public Sprite Red;

    public LineColorProperty line;

    private bool first = true;
    /*
    public LineColorProperty lineGreen;
    public LineColorProperty lineRed;
    public LineColorProperty lineOrange;
    public LineColorProperty lineBlue;
    */ //Da usare quando voglio generare tutti i colori


    // Use this for initialization
    void generate()
    {
        
        int r = Random.Range(1, 5); //Genero un numero casuale, ogni numero è associato a un colore, inbase al numero setto il colore

        //1; //Green
        //2; //Red
        //3; //Orange
        //4; //Blue

        switch (r)
        {
            case 1:
                //line.setColor("Green");                                                   //Metodo se voglio farlo con il generic line che cambia sprite ogni volta
                line.GetComponent<SpriteRenderer>().sprite = Green;
                break;                                                                      //Non mi aggiora la property nell'ggetto, quindi non mette lo sprite, indi non si vede
            case 2:                                                                         //Per usare un singolo colore mettere in line, il prefab del colore specifico
                //line.setColor("Red");  
                line.GetComponent<SpriteRenderer>().sprite = Red;
                break;
            case 3:
                //line.setColor("Orange");  
                line.GetComponent<SpriteRenderer>().sprite = Orange;
                break;
            case 4:
                //line.setColor("Blue");
                line.GetComponent<SpriteRenderer>().sprite = Blue;
                break;
        }     
        

        x = Random.Range(1f, 4f);
        y = Random.Range(-3f, 2.5f);

        if ((System.Math.Abs(System.Math.Abs(appY) - System.Math.Abs(y)) < 0.5f))
          y = y + 1f;
        appY = y;

    }

	void Start () {
        //Inserire controlli per distanziare in altezza e per non metterne 2 o più dello stesso colore sulla stessa y
        //Creare un generatore per ogni tipo di colore, facendo i controlli  fra tutti i colori per creare un percorso giocabile
        int incrementoX = 0;
        for (int  i = 0; i<999; i++)
        {
            Instantiate(line);
            incrementoX = incrementoX + 2;
            generate();
            v.x = x + incrementoX;
            v.y = y;
            line.transform.position = v;
            //line.GetComponent<SpriteRenderer>().sprite = Red;

            // Instantiate(line);

        }
        
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}

}
