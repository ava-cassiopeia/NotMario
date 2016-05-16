﻿using System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using NotMario.Physics.Basics;

namespace NotMario.Physics.Basics
{
	public class BasicRectangle : PhysicsObject
	{
		protected Texture2D texture;

		public BasicRectangle (GraphicsDevice graphics) 
			: base(){
			this.position = new Vector2 (10.0F, 10.0F);
			this.texture = new Texture2D (graphics, 10, 10);

			this.buildColor (Color.Red);
		}

		public BasicRectangle (Color color, GraphicsDevice graphics) 
			: base(){
			this.position = new Vector2 (10.0F, 10.0F);
			this.texture = new Texture2D (graphics, 10, 10);

			this.buildColor (color);
		}

		public BasicRectangle (float x, float y, int width, int height, GraphicsDevice graphics) 
			: base(){
			this.position = new Vector2 (x, y);
			this.texture = new Texture2D (graphics, width, height);

			this.buildColor (Color.Red);
		}

		public BasicRectangle (float x, float y, int width, int height, Color color, GraphicsDevice graphics) 
			: base(){
			this.position = new Vector2 (x, y);
			this.texture = new Texture2D (graphics, width, height);

			this.buildColor (color);
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
