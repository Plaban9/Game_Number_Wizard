using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NumberWizard : MonoBehaviour 
{
	public Text text;
		
	int max = 1000;
	int min = 1;
	int guess = 500;
	public int maxGuesses = 10;
	
	
	// Use this for initialization
	void Start () 
	{
		StartGame();
	}
	
	void StartGame()
	{
		guess = Random.Range( min, max + 1);
		text.text = guess.ToString();
		/*print ("++++++++++++++++++++++++++++++++++++++++++++");
		print("Welcome to Number Wizard");
		print("Pick a number in your head and don't tell me.");
		print("The highest number you can pick is " + max);
		
		//Rounding off to add 1000
		max += 1;
		
		print("The lowest number you can pick is " + min);
		print("Is the number higher or lower than " + guess + "?");*/
		
	}
	
	void NextGuess()
	{
		guess = Random.Range(min, max + 1);
		//guess = (max + min) / 2;
		text.text = guess.ToString();
		--maxGuesses;
		
		if (maxGuesses <= 0)
		{
			Application.LoadLevel("Win");
		}
		
		/*print("Higher or Lower than " + guess + "?");
		print("Up arrow for Higher, Down for Lower and Return for Equal");*/
	}
	
	void ResetNumbers()
	{
		max = 1000;
		min = 1;
		guess = 500;
	}
	
	public void GuessHigher()
	{
		min = guess;
		NextGuess();
	}
	
	public void Guesslower()
	{
		max = guess;
		NextGuess();
	}
}