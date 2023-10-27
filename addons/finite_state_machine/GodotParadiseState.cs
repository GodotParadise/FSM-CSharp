using Godot;
using Godot.Collections;
using System.Collections.Generic;

public partial class GodotParadiseState : Node
{
	[Signal]
	public delegate void StateEnteredEventHandler();


	[Signal]
	public delegate void StateFinishedEventHandler(GodotParadiseState nextState, Dictionary parameters);

	Array<GodotParadiseState> PreviousStates = new();
	Dictionary parameters = new();



	public virtual void Enter()
	{

	}

	public virtual void Exit()
	{

	}

	public virtual void HandleInput(InputEvent inputEvent)
	{

	}

	public virtual void PhysicsUpdate(double delta)
	{

	}

	public virtual void Update(double delta)
	{

	}

	public virtual void OnAnimationPlayerFinished(string Name)
	{

	}

	public virtual void OnAnimationFinished()
	{

	}
}
