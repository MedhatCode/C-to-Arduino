int led=8;
int pwm=11;
byte data[4];
void setup() {  
  // put your setup code here, to run once:
 Serial.begin(9600);
 pinMode(led,OUTPUT);
 pinMode(pwm,OUTPUT);
 
}

void loop() {
  // put your main code here, to run repeatedly:
if(Serial.available()>0){
  Serial.readBytes(data,4);
  if(data[1]=='t'){
    digitalWrite(led,HIGH);
    }
  else if(data[1]=='f'){
    digitalWrite(led,LOW);
    }
  else{
  int val=int((unsigned char)(data[0])<<24|(unsigned char)(data[1])<<16|(unsigned char)(data[2])<<8|(unsigned char)(data[0]));
  analogWrite(pwm,val);
  Serial.flush();
  }
}}
