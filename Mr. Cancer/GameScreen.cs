﻿//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 도구를 사용하여 생성되었습니다.
//     코드가 다시 생성될 경우 이 파일이 손실됩니다.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class GameScreen : Screen
{
	public virtual List<MoveableObject> moL
	{
		get;
		set;
	}

	public virtual DrawMamager DrawMamager
	{
		get;
		set;
	}

	public virtual MoveableObject MoveableObject
	{
		get;
		set;
	}

	public virtual Player Player
	{
		get;
		set;
	}

	public virtual StageManager StageManager
	{
		get;
		set;
	}

	public virtual void AddObject(String Code, Pixel px)
	{
		throw new System.NotImplementedException();
	}

	public virtual void RemoveObject(String Code)
	{
		throw new System.NotImplementedException();
	}

	public virtual void MoveObject(String Code)
	{
		throw new System.NotImplementedException();
	}

	public virtual void AddBackground(Image bitmap)
	{
		throw new System.NotImplementedException();
	}

	public virtual void ChangeBackground(Image bitmap)
	{
		throw new System.NotImplementedException();
	}

	public virtual void RequestSkill(string code1, string code2)
	{
		throw new System.NotImplementedException();
	}

	public virtual void getBackground()
	{
		throw new System.NotImplementedException();
	}

	public virtual void getObjectList()
	{
		throw new System.NotImplementedException();
	}

	public virtual void getNextStage()
	{
		throw new System.NotImplementedException();
	}

	public virtual void getObjectCode()
	{
		throw new System.NotImplementedException();
	}

	public virtual void getMessage()
	{
		throw new System.NotImplementedException();
	}

	public virtual void ScreenOnLoad()
	{
		throw new System.NotImplementedException();
	}

	public virtual void ScreenOff()
	{
		throw new System.NotImplementedException();
	}

}

