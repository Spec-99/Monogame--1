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
        // Clear the Back Buffer
        GraphicsDevice.Clear(Color.White);

        //The bounds of the icon whin the texture
        Rectangle iconSourceRect = new Rectangle(0, 0, 128, 128);

        //The bounds of the word mark within the texture.
        Rectangle wordmarkSourceRect = new Rectangle(150, 34, 458, 58);

        // Begin the sprite batch... to prepare for rendering 
        SpriteBatch.Begin(sortMode: SpriteSortMode.FrontToBack);

        
        SpriteBatch.Draw(
            _logo, //texture 
         new Vector2(Window.ClientBounds.Width, Window.ClientBounds.Height) * 0.5f, //position
        iconSourceRect,     //SourceRectangle 
        Color.DarkGreen,    //Color
        0.0f,               //Rotation 
        new Vector2(
            iconSourceRect.Width,
            iconSourceRect.Height) * 0.5f, //origin
        1.0f,               //Scale 
        SpriteEffects.None, //Effects
        1.0f                //LayerDepth
        );

        SpriteBatch.Draw(
            _logo, //texture 
        new Vector2(Window.ClientBounds.Width, Window.ClientBounds.Height) * 0.5f, //position 
       wordmarkSourceRect,               //SourceRectangle 
       Color.DarkGreen,    //Color
       0.0f,               //Rotation 
       new Vector2(wordmarkSourceRect.Width,wordmarkSourceRect.Height) * 0.5f, //origin
        1.0f,               //Scale 
        SpriteEffects.None, //Effects
        0.0f                //LayerDepth
        );

        // Always end the sprite batch when finished.
        SpriteBatch.End();

        base.Draw(gameTime);
    }
}
