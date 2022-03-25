using System;

class Program
{
	static void Main(string[] args)
	{
		Star star = new Star(0);
		GoombaAdv goombaAdv = new GoombaAdv(4);
		Ground ground = new Ground(120);
		GoombaWalk gWalkAnimation = new GoombaWalk(star, goombaAdv, ground);
		Console.Clear();
		gWalkAnimation.StartAnimation();
	}
}
