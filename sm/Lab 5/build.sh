docker build -t apache-php-gd . 
docker run -d -p 80:80 --name lab5 -v "$PWD/src":/var/www/html apache-php-gd
