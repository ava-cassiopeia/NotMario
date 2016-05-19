﻿using System;
using System.Collections.Generic;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using NotMario.Game.Elements;

namespace NotMario.Game.Levels
{
	public class Level
	{
		protected List<GameObject> objects;

		public string name;

		public Level (){
			this.objects = new List<GameObject> ();
			this.name = "[empty name]";
		}

		public void addObject(GameObject gameObject){
			this.objects.Add(gameObject);
		}

		public void Dispose(){
			IEnumerator<GameObject> iterator = objects.GetEnumerator ();

			while (iterator.MoveNext()) {
				GameObject curr = iterator.Current;

				curr.Dispose ();
			}
		}

		public void Draw(SpriteBatch batch){
			IEnumerator<GameObject> iterator = objects.GetEnumerator ();

			while (iterator.MoveNext()) {
				GameObject curr = iterator.Current;

				curr.Draw (batch);
			}
		}
	}
}
