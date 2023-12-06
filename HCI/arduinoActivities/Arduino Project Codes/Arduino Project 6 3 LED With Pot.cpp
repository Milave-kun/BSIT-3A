// Arduino Project 6 3 LED With pot

int potPin = A3;
int potVal = 0;

int redPin = 9;
int ylwPin = 10;
int grnPin = 11;

int redVal = 0;
int ylwVal = 0;
int grnVal = 0;

void setup()
{
  pinMode(redPin, OUTPUT);
  pinMode(ylwPin, OUTPUT);
  pinMode(grnPin, OUTPUT);
}

void loop()
{
  potVal = analogRead(potPin);

  if (potVal < 341)
  {
    potVal = (potVal * 3) / 4;

    redVal = potVal;
    ylwVal = 0;
    grnVal = 0;
  }
  else if (potVal < 682)
  {
    potVal = ((potVal - 341) * 3) / 4;

    redVal = 0;
    ylwVal = potVal;
    grnVal = 0;
  }
  else
  {
    potVal = ((potVal - 682) * 3) / 4;

    redVal = 0;
    ylwVal = 0;
    grnVal = potVal;
  }

  analogWrite(redPin, redVal);
  analogWrite(ylwPin, ylwVal);
  analogWrite(grnPin, grnVal);
}
