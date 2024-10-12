# PlayMinecraftBingo

## How to update Docker image

In repository root directory:

`sudo docker build -f Dockerfile.txt -t web:PlayMinecraftBingo .`

Then:

`cd ~/Server01Config/DockerCompose/web-PlayMinecraftBingo`

`sudo docker-compose up --detach --force-recreate`
