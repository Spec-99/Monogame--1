using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGameLibrary;


namespace _1;

public class Game1 : Core
{

    private Texture2D _logo;
    public Game1() : base("Dungeon Slime", 1280, 720, false)
    {

    }

    protected override void Initialize()
    {
        // TODO: Add your initialization logic here

        base.Initialize();
    }

    protected override void LoadContent()
    {
        //ToDo: use this.Content to load your gme content here 
        base.LoadContent();
        _logo = Content.Load<Texture2D>("images/logo");
    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.White);

        // Begin the sprite batch... to prepare for rendering 
        SpriteBatch.Begin();

        // Draw the logo texture
        SpriteBatch.Draw(_logo, //texture 
         new Vector2(       //position
            (Window.ClientBounds.Width * 0.5f) - (_logo.Width * 0.5f),
            (Window.ClientBounds.Height * 0.5f) - (_logo.Height * 0.5f)
                    ),
        null,               //SourceRectangle 
        Color.DarkGreen,    //Color
        0.0f,               //Rotation 
        Vector2.Zero,       //Origin 
        1.0f,               //Scale 
        SpriteEffects.None, //Effects
        0.0f                //LayerDepth
        );

        // Always end the sprite batch when finished.
        SpriteBatch.End();

        base.Draw(gameTime);
    }
}
