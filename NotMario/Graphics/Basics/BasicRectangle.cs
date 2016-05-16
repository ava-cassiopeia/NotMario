﻿using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace NotMario.Graphics.Basics
{
	public class BasicRectangle
	{
		protected Texture2D texture;

		public Vector2 position;

		public BasicRectangle (GraphicsDevice graphics)
		{
			this.position = new Vector2 (10.0F, 10.0F);
			this.texture = new Texture2D (graphics, 10, 10);

			this.buildColor (Color.Red);
		}

		protected void buildColor(Color color){
			int x = this.texture.Bounds.Height;
			int y = this.texture.Bounds.Width;
			int dimension = x * y;

			Color[] colorMap = new Color[dimension];

			for (int i = 0; i < dimension; i++) {
				colorMap [i] = color;
			}

			this.texture.SetData<Color> (colorMap);
		}

		public void Draw(SpriteBatch batch){
			batch.Draw (this.texture, this.position);
		}
	}
}

