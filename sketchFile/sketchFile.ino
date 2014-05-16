
#include <MCP3551.h>
#include <SPI.h>

//#define ANALOG_INPUT 1
#define ADC_INPUT 1

#define SS 10

float fRawData;
MCP3551 MCP_ADC(SS);


float difference= 0.0;
float sig_plus = 0.0;
float sig_minus = 0.0;

void setup(){
  pinMode( SS, OUTPUT );
   
  // initialize serial communication at 9600 bits per second:
  Serial.begin(9600);
  Serial.println("Setup done.");
  analogReference(EXTERNAL);
  pinMode(A0, INPUT);
  pinMode(A1, INPUT);
}

float getRawData(){
  double fVar = 0;
  int i = 0;
  bool isReady = MCP_ADC.getCode();
  if( isReady ){
    Serial.print("Raw data:");
    Serial.print(MCP_ADC.byteCode, DEC);
    Serial.println();
     Serial.print(MCP_ADC.byteCode, BIN);
    Serial.println();
    delay(1000);
  }
}

void loop(){
  
  #ifdef ADC_INPUT
  getRawData();
  #endif
  
  #ifdef ANALOG_INPUT
  Serial.print("Analog 0  :");
  
  sig_plus = analogRead(A0) *(5/1023.0);
  sig_minus = analogRead(A1) *(5/1023.0);
  Serial.print ( "Analog 0: " );
  Serial.print(sig_plus);
  Serial.print ("V.");
  Serial.println();
  
  Serial.print("Analog 1  :");
  Serial.print (sig_minus);
  Serial.print ("V.");
  Serial.println();
  
  difference = sig_plus - sig_minus;
  Serial.print("Difference: ");
  Serial.print(difference);
  Serial.println();
  delay(1000);
  
  #endif
}
