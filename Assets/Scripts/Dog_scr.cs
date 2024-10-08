using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Dog_scr : MonoBehaviour
{
    public SpriteRenderer dogSprite;
    public TextMeshProUGUI dogText;
    public DogBreed dogBreed;

    public enum DogBreed
    {
        AustralianShepherd,
        Beagle,
        BoderCollie,
        ChowChow,
        Corgi,
        ShibaInu,
        GoldenRetriever,
        LabradorRetriever,
        Maltipoo,
        ShetlandSheepdog
    }

    public void UpdateDogInfo()
    {
        switch(dogBreed)
        {
            case DogBreed.AustralianShepherd:
                dogText.text = "Australian Shepherd\nVery good dog.";
                dogSprite.sprite = Resources.Load<Sprite>("australian");
                break;
            case DogBreed.Beagle:
                dogText.text = "Beagle\nLittle hunting dog, very loud.";
                dogSprite.sprite = Resources.Load<Sprite>("beagle");
                break;
            case DogBreed.BoderCollie:
                dogText.text = "Border Collie\nVery active. Needs to do things.";
                dogSprite.sprite = Resources.Load<Sprite>("border");
                break;
            case DogBreed.ChowChow:
                dogText.text = "Chow Chow\nTemperamental. Has a dark colored tongue.";
                dogSprite.sprite = Resources.Load<Sprite>("chow");
                break;
            case DogBreed.Corgi:
                dogText.text = "Corgi\nRegal..";
                dogSprite.sprite = Resources.Load<Sprite>("corgi");
                break;
            case DogBreed.LabradorRetriever:
                dogText.text = "Labrador Retriever\nLikes to fetch.";
                dogSprite.sprite = Resources.Load<Sprite>("labrador");
                break;
            case DogBreed.GoldenRetriever:
                dogText.text = "Golden Retriever\nMy uncle had a dog who was born from a purebred golden retriever, but all the puppies had straight black fur.";
                dogSprite.sprite = Resources.Load<Sprite>("golden");
                break;
            case DogBreed.ShibaInu:
                dogText.text = "Shiba Inu\nVery dog\n much good\n  give pats.";
                dogSprite.sprite = Resources.Load<Sprite>("doge");
                break;
            case DogBreed.Maltipoo:
                dogText.text = "Maltipoo\nLittle dogs are demonic.";
                dogSprite.sprite = Resources.Load<Sprite>("maltipoo");
                break;
            case DogBreed.ShetlandSheepdog:
                dogText.text = "Shetland Sheepdog\nHas a kind of dopey face.";
                dogSprite.sprite = Resources.Load<Sprite>("shetland");
                break;
        }
    }
    public void Start()
    {
        UpdateDogInfo();
    }
}
