
#include <MCP3551.h>
#include <SPI.h>

//#define ANALOG_INPUT 1
#define ADC_INPUT 1
#define DEBUG_PROGRAM 1
#define SETDOWN_TIME_MS 5000
#define READINGTIME_SMOOTH 2000

#define SS 10

float fRawData;
MCP3551 MCP_ADC(SS);


float difference= 0.0;
float sig_plus = 0.0;
float sig_minus = 0.0;
float globalAverage = 0.0;
float baseFigure = 0.0;
float fMetricWeight = 0.0;

void setup(){
  // initialize serial communication at 9600 bits per second:
  Serial.begin(9600);
  Serial.println("Setup done.");
  
  #ifdef ANALOG_INPUT
    analogReference(EXTERNAL);
    pinMode(A0, INPUT);
    pinMode(A1, INPUT);
  #endif
  
}

void getRawData(){
  bool isReady = MCP_ADC.getCode();
  if( isReady ){
    Serial.print("Raw data:");
    Serial.print(MCP_ADC.byteCode, DEC);
    Serial.println();
     Serial.print(MCP_ADC.byteCode, BIN);
    Serial.println();
    delay(2000);
  }
}

float setdownData(){
  unsigned int startTime = millis();
  float localSum = 0.0;
  unsigned int nCount = 0;
  
  
  while( (millis() - startTime) < SETDOWN_TIME_MS){
    bool isReady = MCP_ADC.getCode();
    if( isReady ){
      localSum = nCount * globalAverage;
      localSum +=  MCP_ADC.byteCode;
      nCount += 1;
      globalAverage = localSum / nCount ;
    }
  }
  
  return globalAverage;
}

float getSmoothReading(){
  float avg = 0.0;
  float sum = 0.0;
  float fCount = 0.0;
  
  long thisTime = millis();
  while( (millis() - thisTime) < READINGTIME_SMOOTH){
    bool isReady = MCP_ADC.getCode();
    if( isReady ){
      sum = fCount * avg;
      sum += MCP_ADC.byteCode;
      fCount += 1;
      avg = sum / fCount;
    }
  }
  return avg;
}

void loop(){
  
  #ifdef DEBUG_PROGRAM
  
    baseFigure = setdownData();
    Serial.print("Setdown data locked:");
    Serial.print(baseFigure, DEC);
    Serial.println();
    
    Serial.println("Now looking for change");
    
    while(true){
      fMetricWeight = getSmoothReading() - baseFigure;
      if(fMetricWeight  < 10.0 && fMetricWeight > - 10.0){
        fMetricWeight = 0.0;
      }
      Serial.print( fMetricWeight, DEC );
      Serial.print(" Kg");
      Serial.println();
    }
    
  #endif
  
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
