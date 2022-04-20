**Resources.GetColor** has been deprecated. Make sure you use **ContextCompat.GetColor** instead.
So:
	**Resources.GetColor(Resource.Color.HoloOrangeDark);**
Will become:
	**int colorInt = ContextCompat.GetColor(this.Context, Resource.Color.HoloOrangeDark));**
  
ContextCompat returns a int so to get a Color out of it just create a new color and pass in the int.
  **Color color = new Color(colorInt);**
  
**Some cases:**
var backgroundColor = Android.Support.V4.Content.ContextCompat.GetColor(context, Resource.Color.dialog_background_transparent);
var backgroundColor = Android.Support.V4.Content.Res.ResourcesCompat.GetColor(Resources, Resource.Color.dialog_background_transparent, context.Theme);
