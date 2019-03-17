# RedisDemo

## Install Redis

### 1.Setup WSL

Open PowerShell as Administrator and run this command to enable Windows Subsystem for Linux (WSL):
```
Enable-WindowsOptionalFeature -Online -FeatureName Microsoft-Windows-Subsystem-Linux
```
Reboot Windows
Download and install one of the supported Linux distros from the Microsoft Store.

### 2.Install and Test Redis

Run cmd and enter:
```
bash
```
Install redis-server:
```
> sudo apt-get update
> sudo apt-get upgrade
> sudo apt-get install redis-server
> redis-cli -v
```
Restart the Redis server to make sure it is running:
```
> sudo service redis-server restart
```
