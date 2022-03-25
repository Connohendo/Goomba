using System;
using System.Threading;

class GoombaWalk
{
	private Star star;
	private Goomba goomba;
	private Ground ground;
	public GoombaWalk(Star star, Goomba goomba, Ground ground)
	{
		this.star = star;
		this.goomba = goomba;
		this.ground = ground;
	}
	public void DrawFrame()
	{
		star.DrawSprite();
		goomba.DrawSprite();
		ground.DrawSprite();
	}
public void StartAnimation()
	{
		int frameNumb = 20;
		int sleepTime = 200;
		for(int i = 0; i < frameNumb; i++)
		{ 	
			Console.Clear();         
			DrawFrame();            
			goomba.UpdatePos();
			Thread.Sleep(sleepTime);      
		}
		goomba.ChangeDir(); 
		goomba.UpdatePos();
		for(int i = 0; i < frameNumb; i++)
		{ 	
			Console.Clear();         
			DrawFrame();            
			goomba.UpdatePos();
			Thread.Sleep(sleepTime);      
		}	
	}
}