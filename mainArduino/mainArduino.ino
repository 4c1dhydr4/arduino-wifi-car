#include <SPI.h>
#include <Ethernet.h>
#include <EthernetUdp.h>
#include "DHT.h"
#define DHTPIN 7
#define DHTTYPE DHT11 
DHT dht(DHTPIN, DHTTYPE);
int del = 100;

const int S1 = A0, S2 = A1, S3 = A2, S4 = A3, S5 = A4, S6 = A5;
int s1, s2, s3, s4, s5, s6, s7;
int times = 0, reset_times=200;
const int Tigger = 13, Echo = 12;
int counterUDP = 0;

byte mac[] = {0x90, 0xA2, 0xDA, 0x0E, 0xD9, 0x91 };
IPAddress ip(192, 168, 1, 177);
unsigned int localPort = 8888, remoteUDPPort = 8242;

char packetBuffer[UDP_TX_PACKET_MAX_SIZE];
EthernetUDP Udp;

char incomingByte;
char Byte[50];
int i, count = 0;
const int in1 = 3; //motor izquierdo delante
const int in2 = 5; //motor izquierda atras
const int in3 = 6; //motor derecho atras
const int in4 = 9; //motor derecho adelante

void setup() {
  Serial.begin(9600);
  Ethernet.begin(mac, ip);
  Udp.begin(localPort);
  pinMode(in1, OUTPUT);
  pinMode(in2, OUTPUT);
  pinMode(in3, OUTPUT);
  pinMode(in4, OUTPUT);
  pinMode(Tigger, OUTPUT);
  pinMode(Echo, INPUT);
  dht.begin();
  reset();
}

void loop() {
 controlCar();
 //refresh_sensors();
 delay(10);
}
/*Control del Carro*/
void controlCar(){
  int packetSize = Udp.parsePacket();
  if(packetSize){
    for(int i=0;i<UDP_TX_PACKET_MAX_SIZE;i++){
      packetBuffer[i] = 0;
    }
    Udp.read (packetBuffer, UDP_TX_PACKET_MAX_SIZE);
    if(counterUDP == 50){
      //sendSensors();
      counterUDP = 0;  
    }
    counterUDP++;
    String command = packetBuffer;
    while(command == "i"){
      izquierda();
      delay(del);
      command = "";
    }
    while(command == "d"){
      derecha();
      delay(del);
      command = "";
    }
    while(command == "a"){
      acelera();
      delay(del);
      command = "";
    }
    while(command == "f"){
      retrocede();
      delay(del);
      command = "";
    }
    stopCar();
  }
}

void acelera(){
  digitalWrite(in1, HIGH);
  digitalWrite(in3, HIGH);
  digitalWrite(in2, LOW);
  digitalWrite(in4, LOW);
}
void retrocede(){
  digitalWrite(in1, LOW);
  digitalWrite(in3, LOW);
  digitalWrite(in2, HIGH);
  digitalWrite(in4, HIGH);
}
void derecha(){
  digitalWrite(in1, HIGH);
  digitalWrite(in3, LOW);
  digitalWrite(in2, LOW);
  digitalWrite(in4, HIGH);
}
void izquierda(){
  digitalWrite(in1, LOW);
  digitalWrite(in3, HIGH);
  digitalWrite(in2, HIGH);
  digitalWrite(in4, LOW);
}
void stopCar(){
  digitalWrite(in1, LOW);
  digitalWrite(in3, LOW);
  digitalWrite(in2, LOW);
  digitalWrite(in4, LOW);
}
/***********************/
/*Envío de Datos*/
void sendSensors(){
  for(int i=1; i<=8; i++){
    sendPeerSensor(i);
  }
}
void reset(){
  s1 = 0; s2 = 0; s3 = 0; s4 = 0; s5 = 0; s6 = 0; s7 = 0;
}
void sendPeerSensor(int i){
  if(i == 1){
    sendUDP('M',s1);//Metano
  }
  if(i == 2){
    sendUDP('S',s2);//Sonido
  }
  if(i == 3){
    sendUDP('T',s3);//Temperatura
  }
  if(i == 4){
    sendUDP('F',s4);//Fuego
  }
  if(i == 5){
    sendUDP('L',s5);//Luz
  }
  if(i == 6){
    sendUDP('P',s1);//Propano
  }
  if(i == 7){
    sendUDP('H',s7);//Humedad
  }
  if(i == 8){
    sendUDP('O',s6);//Obstáculos
  }
}
void sendUDP(char letter, int SensorValue){
  Udp.beginPacket(Udp.remoteIP(), remoteUDPPort);
  char charBuf[UDP_TX_PACKET_MAX_SIZE];
  String data = attach_sensorType_value(letter,SensorValue);
  data.toCharArray(charBuf, UDP_TX_PACKET_MAX_SIZE);
  //Serial.println(charBuf);
  Udp.write(charBuf);
  Udp.endPacket();
}
String attach_sensorType_value(char sensorLetter,int sensorValue){
  String resultado = "";
  resultado.concat(sensorLetter);
  resultado.concat(":");
  resultado.concat(sensorValue);
  return resultado;
}
/***********************/
/*Sensores*/
void refresh_sensors(){
  s1 = analogRead(S1); s1 = mapSensorReverse(s1);
  s2 = analogRead(S2); s2 = mapSensor(s2);
  //s3 = analogRead(S3); s3 = mapSensor(s3);
  s4 = analogRead(S4); s4 = mapSensor(s4);
  s5 = analogRead(S5); s5 = mapSensor(s5);
  s6 = distance(); s6 = mapDistance(s6);
  s3 = temp(); s3 = mapTemp(s3);
  s7 = humidity(); s7 = mapHumidity(s7);
}
int mapSensor(int sensorValue){
  int output = map(sensorValue, 0, 1023, 0, 100);
  return output;
}

int mapSensorReverse(int sensorValue){
  int output = map(sensorValue, 1023, 0, 0, 100);
  return output;
}

int mapDistance(int sensorValue){
  int output = map(sensorValue, 200, 0, 0, 100);
  return output;
}

int mapTemp(int sensorValue){
  int output = map(sensorValue, 10, 50, 0, 100);
  return output;
}

int mapHumidity(int sensorValue){
  int output = map(sensorValue, 0, 100, 0, 100);
  return output;
}
/***********************/
/********Distancia*******/
int distance(){
  long t;
  long d;
  digitalWrite(Tigger, HIGH);
  delayMicroseconds(10);
  digitalWrite(Tigger, LOW);
  t = pulseIn(Echo, HIGH);
  d = t/59;
  delay(10);
  return d;

}
/***********************/
/********Humedad y Temperatura*******/
int humidity(){
  int h = dht.readHumidity();
  return h;
}
int temp(){
  int t= dht.readTemperature();
  return t;
}
/***********************/

