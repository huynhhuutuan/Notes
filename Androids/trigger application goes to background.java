// Ref: https://stackoverflow.com/questions/13512180/how-to-trigger-a-function-when-a-user-goes-back-to-a-background-app
//In onPause() method write this code to know that your application is went to background.

public void onPause()
{
    ActivityManager am = (ActivityManager) context.getSystemService(Context.ACTIVITY_SERVICE);
    Boolean flag=false;     

    List<RunningTaskInfo> tasks = am.getRunningTasks(1);
    if (!tasks.isEmpty()) {
        ComponentName topActivity = tasks.get(0).topActivity;
        if (!topActivity.getPackageName().equals(context.getPackageName())) {
            flag=true;
        }
    }
    if(flag)
    {
        //App went to background...
    }
}

// Use the above flag in onResume() to know that your application was resumed.
// In the above code context.getPackageName() means your application package name.