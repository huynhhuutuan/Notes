// Get all debug connected devices
adb devices

// Install a file from computer to android device
adb install "C:\Users\Admin\Programs\<apk_file>.apk"

# CommonUseCmd
常用功能指令总结



## Git

```shell
# 同步fork仓库远程代码
git remote -v
git remote add upstream https:${remote_url}
git fetch upstream
git merge upstream/master
git push origin master

# 暂存文件
git add .
git stash
# 查看暂存区列表
git stash list
# 删除暂存文件
git stash drop
# 恢复缓存
git stash pop
```



## Android adb

### Traces.txt

Android6.0之前

```
adb pull data/anr/traces.txt .
```

>= Android 6.0

```shell
adb bugreport ./bugreport.zip
```



### Android adb shell

```shell
tail -f storage/emulated/0/Android/data/${package_name}/log.log
```

### adb type a text to input box

```shell
adb shell input text 123456
```

### adb connect to phone

```shell
# Get all devices list
adb devices
# Specify a device for adb, <device_id> get from above command
adb -s <device_id>
# Refresh adb server
adb kill-server
# Install a apk to phone
adb install xxx.apk
# Override a installed app (keep app data & cache)
adb install -r -t xxx.apk
# Uninstall a application
adb uninstall <package_name>
# Start app
adb shell am start -n your.package.name/your.package.name-activity
# Get all installed packages name
adb shell pm list packages
# Get all apk path of installed apps
adb shell pm path your.package.name
# Copy files from computer to phone's SD card
adb push <path_on_pc> /sdcard
# Copy files from phone's SD card to computer
adb pull /sdcard/text.txt <path_on_pc>

```
