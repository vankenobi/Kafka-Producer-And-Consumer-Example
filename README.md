
![Logo](https://rohithsankepally.github.io/images/zookeeper-kafka.png)

# Kafka ve Zookeeper Kurulumu + Basit Producer Consumer Uygulaması

Bu projede kafka + zookeeper container kurulumları ve basit bir producer consumer uygulaması oluşturulmuştur.





## Kullanılan Teknolojiler

* Docker  
* Asp.net Core
* Apache Kafka
* Zookeeper






  
## Kullanım/Örnekler

#### Zookeeper container kurulum komutu

```docker
docker run --name zookeeper -p 2181:2181 zookeeper
```

#### Kafka container kurulum komutu
```docker
docker run --name kafka -p 9092:9092 
    -e KAFKA_ZOOKEEPER_CONNECT=192.168.43.2:2181 
    -e KAFKA_ADVERTISED_LISTENERS=PLAINTEXT://192.168.43.2:9092 
    -e KAFKA_OFFSETS_TOPIC_REPLICATION_FACTOR=1 
confluentinc/cp-kafka
```

```

-e KAFKA_ZOOKEEPER_CONNECT : Local ip adresi + zookeeper çalıştığı port
-e KAFKA_ADVERTISED_LISTENERS : Local ip adresi + zookeeper çalıştığı port
-e KAFKA_OFFSETS_TOPIC_REPLICATION_FACTOR : Local ip adresi + zookeeper çalıştığı port

```


## Çalışma Örneği

![Gif Dosyası](https://github.com/vankenobi/Kafka-Producer-And-Consumer-Example/blob/master/Kafka-%C3%96rnek-Uygulama-%C3%87al%C4%B1%C5%9Fma-Videosu.gif)
