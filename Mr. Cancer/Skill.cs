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

public interface Skill 
{
	object string code { get;set; }

	GameScreen GameScreen { get;set; }

	void Effect(object MoveableObject mo);

}

