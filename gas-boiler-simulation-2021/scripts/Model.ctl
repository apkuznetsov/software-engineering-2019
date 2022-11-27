// region FEF
const string reqFefIsOn = "System1:FEF.States.IsOn:_online.._value";
const string reqFefValue = "System1:FEF.Inputs.Positions:_online.._value";

const string reqValveFefBeforeIsOpened = "System1:VALVE_FEF_BEFORE.IsOpened:_online.._value";
const string reqValveFefAfterIsOpened = "System1:VALVE_FEF_AFTER.IsOpened:_online.._value";
const string reqValveFefBurner1IsOpened = "System1:VALVE_FEF_BURNER_1.IsOpened:_online.._value";
const string reqValveFefBurner2IsOpened = "System1:VALVE_FEF_BURNER_2.IsOpened:_online.._value";
const string reqValveFefBurner3IsOpened = "System1:VALVE_FEF_BURNER_3.IsOpened:_online.._value";
const string reqValveFefBurner4IsOpened = "System1:VALVE_FEF_BURNER_4.IsOpened:_online.._value";

const string reqPlg1Value = "System1:PLG_1.Inputs.Positions:_online.._value";
const string reqPlg2Value = "System1:PLG_2.Inputs.Positions:_online.._value";
const string reqPlg3Value = "System1:PLG_3.Inputs.Positions:_online.._value";
const string reqPlg4Value = "System1:PLG_4.Inputs.Positions:_online.._value";

const string reqDefaultFefValue = "System1:FEF.Inputs.Positions:_default.._value";

const string reqDefaultPlg1Value = "System1:PLG_1.Inputs.Positions:_default.._value";
const string reqDefaultPlg2Value = "System1:PLG_2.Inputs.Positions:_default.._value";
const string reqDefaultPlg3Value = "System1:PLG_3.Inputs.Positions:_default.._value";
const string reqDefaultPlg4Value = "System1:PLG_4.Inputs.Positions:_default.._value";

const string setFefIsOn = "System1:FEF.States.IsOn:_original.._value";
const string setFefValue = "System1:FEF.Inputs.Positions:_original.._value";

const string setValveFefBeforeIsOpened = "System1:VALVE_FEF_BEFORE.IsOpened:_original.._value";
const string setValveFefAfterIsOpened = "System1:VALVE_FEF_AFTER.IsOpened:_original.._value";
const string setValveFefBurner1IsOpened = "System1:VALVE_FEF_BURNER_1.IsOpened:_original.._value";
const string setValveFefBurner2IsOpened = "System1:VALVE_FEF_BURNER_2.IsOpened:_original.._value";
const string setValveFefBurner3IsOpened = "System1:VALVE_FEF_BURNER_3.IsOpened:_original.._value";
const string setValveFefBurner4IsOpened = "System1:VALVE_FEF_BURNER_4.IsOpened:_original.._value";

const string setPlg1IsOn = "System1:PLG_1.States.IsOn:_original.._value";
const string setPlg2IsOn = "System1:PLG_2.States.IsOn:_original.._value";
const string setPlg3IsOn = "System1:PLG_3.States.IsOn:_original.._value";
const string setPlg4IsOn = "System1:PLG_4.States.IsOn:_original.._value";

const string setPlg1Value = "System1:PLG_1.Inputs.Positions:_original.._value";
const string setPlg2Value = "System1:PLG_2.Inputs.Positions:_original.._value";
const string setPlg3Value = "System1:PLG_3.Inputs.Positions:_original.._value";
const string setPlg4Value = "System1:PLG_4.Inputs.Positions:_original.._value";

float defaultFefValue;

float defaultPlg1Value;
float defaultPlg2Value;
float defaultPlg3Value;
float defaultPlg4Value;
// endregion FEF

// region FEM
const string reqFemIsOn = "System1:FEM.States.IsOn:_online.._value";
const string reqFemValue = "System1:FEM.Inputs.Positions:_online.._value";

const string reqValveFemBeforeIsOpened = "System1:VALVE_FEM_BEFORE.IsOpened:_online.._value";
const string reqValveFemAfterIsOpened = "System1:VALVE_FEM_AFTER.IsOpened:_online.._value";
const string reqValveFemBurner1IsOpened = "System1:VALVE_FEM_BURNER_1.IsOpened:_online.._value";
const string reqValveFemBurner2IsOpened = "System1:VALVE_FEM_BURNER_2.IsOpened:_online.._value";
const string reqValveFemBurner3IsOpened = "System1:VALVE_FEM_BURNER_3.IsOpened:_online.._value";
const string reqValveFemBurner4IsOpened = "System1:VALVE_FEM_BURNER_4.IsOpened:_online.._value";

const string reqDefaultFemValue = "System1:FEM.Inputs.Positions:_default.._value";

const string setFemIsOn = "System1:FEM.States.IsOn:_original.._value";
const string setFemValue = "System1:FEM.Inputs.Positions:_original.._value";

const string setValveFemBeforeIsOpened = "System1:VALVE_FEM_BEFORE.IsOpened:_original.._value";
const string setValveFemAfterIsOpened = "System1:VALVE_FEM_AFTER.IsOpened:_original.._value";
const string setValveFemBurner1IsOpened = "System1:VALVE_FEM_BURNER_1.IsOpened:_original.._value";
const string setValveFemBurner2IsOpened = "System1:VALVE_FEM_BURNER_2.IsOpened:_original.._value";
const string setValveFemBurner3IsOpened = "System1:VALVE_FEM_BURNER_3.IsOpened:_original.._value";
const string setValveFemBurner4IsOpened = "System1:VALVE_FEM_BURNER_4.IsOpened:_original.._value";

float defaultFemValue;
// endregion FEM

// region AIR_1
const string reqValveAir1IsOpened = "System1:VALVE_AIR_1.IsOpened:_online.._value";
const string reqValveAirBurner1IsOpened = "System1:VALVE_AIR_BURNER_1.IsOpened:_online.._value";
const string reqValveAirBurner2IsOpened = "System1:VALVE_AIR_BURNER_2.IsOpened:_online.._value";

const string setTra1IsOn = "System1:TRA_1.States.IsOn:_original.._value";
const string setTra3IsOn = "System1:TRA_3.States.IsOn:_original.._value";
const string setRah1IsOn = "System1:RAH_1.States.IsOn:_original.._value";

const string setValveAirBurner1IsOpened = "System1:VALVE_AIR_BURNER_1.IsOpened:_original.._value";
const string setValveAirBurner2IsOpened = "System1:VALVE_AIR_BURNER_2.IsOpened:_original.._value";

const string setPla1IsOn = "System1:PLA_1.States.IsOn:_original.._value";
const string setPla2IsOn = "System1:PLA_2.States.IsOn:_original.._value";
// endregion AIR_1

// region AIR_2
const string reqValveAir2IsOpened = "System1:VALVE_AIR_2.IsOpened:_online.._value";
const string reqValveAirBurner3IsOpened = "System1:VALVE_AIR_BURNER_3.IsOpened:_online.._value";
const string reqValveAirBurner4IsOpened = "System1:VALVE_AIR_BURNER_4.IsOpened:_online.._value";

const string setTra2IsOn = "System1:TRA_2.States.IsOn:_original.._value";
const string setTra4IsOn = "System1:TRA_4.States.IsOn:_original.._value";
const string setRah2IsOn = "System1:RAH_2.States.IsOn:_original.._value";

const string setValveAirBurner3IsOpened = "System1:VALVE_AIR_BURNER_3.IsOpened:_original.._value";
const string setValveAirBurner4IsOpened = "System1:VALVE_AIR_BURNER_4.IsOpened:_original.._value";

const string setPla3IsOn = "System1:PLA_3.States.IsOn:_original.._value";
const string setPla4IsOn = "System1:PLA_4.States.IsOn:_original.._value";
// endregion AIR_2

// region FAN
const string reqFanIsOn = "System1:FAN.States.IsOn:_online.._value";

const string setFanIsOn = "System1:FAN.States.IsOn:_original.._value";
const string setFanCanWork = "System1:FAN.States.CanWork:_original.._value";
// endregion FAN

// region BURNERS
const string reqBurner1IsOn = "System1:BURNER_1.States.IsOn:_online.._value";
const string reqBurner2IsOn = "System1:BURNER_2.States.IsOn:_online.._value";
const string reqBurner3IsOn = "System1:BURNER_3.States.IsOn:_online.._value";
const string reqBurner4IsOn = "System1:BURNER_4.States.IsOn:_online.._value";

const string setBurner1IsOn = "System1:BURNER_1.States.IsOn:_original.._value";
const string setBurner2IsOn = "System1:BURNER_2.States.IsOn:_original.._value";
const string setBurner3IsOn = "System1:BURNER_3.States.IsOn:_original.._value";
const string setBurner4IsOn = "System1:BURNER_4.States.IsOn:_original.._value";

const string setBurner1CanWork = "System1:BURNER_1.States.CanWork:_original.._value";
const string setBurner2CanWork = "System1:BURNER_2.States.CanWork:_original.._value";
const string setBurner3CanWork = "System1:BURNER_3.States.CanWork:_original.._value";
const string setBurner4CanWork = "System1:BURNER_4.States.CanWork:_original.._value";
// endregion BURNERS

// region PROBS
const string reqDistrIsRandom = "System1:DISTR.IsRandom:_online.._value";
const string reqDistrLowerBound = "System1:DISTR.LowerBound:_online.._value";
const string reqDistrUpperBound = "System1:DISTR.UpperBound:_online.._value";

const string reqProbBurner1 = "System1:BURNER_1.Inputs.FailureProb:_online.._value";
const string reqProbBurner2 = "System1:BURNER_2.Inputs.FailureProb:_online.._value";
const string reqProbBurner3 = "System1:BURNER_3.Inputs.FailureProb:_online.._value";
const string reqProbBurner4 = "System1:BURNER_4.Inputs.FailureProb:_online.._value";

const string reqProbFan = "System1:FAN.Inputs.FailureProb:_online.._value";
// endregion PROBS

// region AUTO
const string reqAutoIsOn = "System1:AUTO.IsOn:_online.._value";
const string setAutoIsOn = "System1:AUTO.IsOn:_original.._value";
// endregion AUTO

main()
{
  // region FEF
  dpGet(reqDefaultFefValue, defaultFefValue);

  dpGet(reqDefaultPlg1Value, defaultPlg1Value);
  dpGet(reqDefaultPlg2Value, defaultPlg2Value);
  dpGet(reqDefaultPlg3Value, defaultPlg3Value);
  dpGet(reqDefaultPlg4Value, defaultPlg4Value);

  dpConnect("modelOnOrOffFef", reqValveFefBeforeIsOpened);
  dpConnect("modelOnOrOffValveFefAfter", reqValveFefAfterIsOpened);
  dpConnect("modelOnOrOffPlg1", reqValveFefBurner1IsOpened);
  dpConnect("modelOnOrOffPlg2", reqValveFefBurner2IsOpened);
  dpConnect("modelOnOrOffPlg3", reqValveFefBurner3IsOpened);
  dpConnect("modelOnOrOffPlg4", reqValveFefBurner4IsOpened);

  dpConnect("failFefNoFlow", reqValveFefBeforeIsOpened);

  dpConnect("failBurner1NoPlg1", reqPlg1Value);
  dpConnect("failBurner2NoPlg2", reqPlg2Value);
  dpConnect("failBurner3NoPlg3", reqPlg3Value);
  dpConnect("failBurner4NoPlg4", reqPlg4Value);
  // endregion FEF

  // region FEM
  dpGet(reqDefaultFemValue, defaultFemValue);

  dpConnect("modelOnOrOffFem", reqValveFemBeforeIsOpened);
  dpConnect("modelOnOrOffValveFemAfter", reqValveFemAfterIsOpened);
  dpConnect("modelOnOrOffFemBurner1", reqValveFemBurner1IsOpened);
  dpConnect("modelOnOrOffFemBurner2", reqValveFemBurner2IsOpened);
  dpConnect("modelOnOrOffFemBurner3", reqValveFemBurner3IsOpened);
  dpConnect("modelOnOrOffFemBurner4", reqValveFemBurner4IsOpened);

  dpConnect("failFemNoFlow", reqValveFemBeforeIsOpened);
  // endregion FEM

  // region AIR_1
  dpConnect("modelOnOrOffAir1Sensors", reqValveAir1IsOpened);
  dpConnect("modelOnOrOffValveAir1", reqValveAir1IsOpened);
  dpConnect("modelOnOrOffPla1", reqValveAirBurner1IsOpened);
  dpConnect("modelOnOrOffPla2", reqValveAirBurner2IsOpened);
  // endregion AIR_1

  // region AIR_2
  dpConnect("modelOnOrOffAir2Sensors", reqValveAir2IsOpened);
  dpConnect("modelOnOrOffValveAir2", reqValveAir2IsOpened);
  dpConnect("modelOnOrOffPla3", reqValveAirBurner3IsOpened);
  dpConnect("modelOnOrOffPla4", reqValveAirBurner4IsOpened);
  // endregion AIR_2

  // region FAN
  dpConnect("modelOnOrOffAirSupply", reqFanIsOn);
  // endregion FAN

  // region BURNERS
  dpConnect("failBrokeBurner1", reqBurner1IsOn);
  dpConnect("failBrokeBurner2", reqBurner2IsOn);
  dpConnect("failBrokeBurner3", reqBurner3IsOn);
  dpConnect("failBrokeBurner4", reqBurner4IsOn);
  // endregion BURNERS

  float floatValue = 0;
  double border_random = 32767;

  int res;
  bool isRandom;
  int lowerBound;
  int upperBound;
  bool isOn;
  float prob;

  while (true)
  {
    res = dpGet(reqDistrIsRandom, isRandom);

    if (isRandom)
    {
      res = dpGet(reqDistrLowerBound, lowerBound);
      res = dpGet(reqDistrUpperBound, upperBound);

      floatValue = (int) (uniform_law(rand()/32767.0, lowerBound, upperBound));
      dpSet(setFefValue, floatValue);
    }

    dpGet(reqBurner1IsOn, isOn);
    if (isOn)
    {
      dpGet(reqProbBurner1, prob);
      if(isProbBroken(prob))
      {
        dpSet(setBurner1CanWork, false);
        dpSet(setBurner1IsOn, false);
      }
    }

    dpGet(reqBurner2IsOn, isOn);
    if (isOn)
    {
      dpGet(reqProbBurner2, prob);
      if(isProbBroken(prob))
      {
        dpSet(setBurner2CanWork, false);
        dpSet(setBurner2IsOn, false);
      }
    }

    dpGet(reqBurner3IsOn, isOn);
    if (isOn)
    {
      dpGet(reqProbBurner3, prob);
      if(isProbBroken(prob))
      {
        dpSet(setBurner3CanWork, false);
        dpSet(setBurner3IsOn, false);
      }
    }

    dpGet(reqBurner4IsOn, isOn);
    if (isOn)
    {
      dpGet(reqProbBurner4, prob);
      if(isProbBroken(prob))
      {
        dpSet(setBurner4CanWork, false);
        dpSet(setBurner4IsOn, false);
      }
    }

    dpGet(reqFanIsOn, isOn);
    if (isOn)
    {
      dpGet(reqProbFan, prob);
      if(isProbBroken(prob))
      {
        dpSet(setFanCanWork, false);
        dpSet(setFanIsOn, false);
      }
    }

    delay(1);
  }
}

// region FEF
void modelOnOrOffFef(string dpName, bool dpValue)
{
  dpSet(setFefIsOn, dpValue);
}

void modelOnOrOffValveFefAfter(string dpName, bool dpValue)
{
  if (!dpValue)
  {
    dpSet(setValveFefBurner1IsOpened, dpValue,
          setValveFefBurner2IsOpened, dpValue,
          setValveFefBurner3IsOpened, dpValue,
          setValveFefBurner4IsOpened, dpValue);
  }
}

void modelOnOrOffPlg1(string dpName, bool dpValue)
{
  bool isAuto;
  dpGet(reqAutoIsOn, isAuto);

  if (!isAuto)
  {
    float newPlgValue;

    if (dpValue)
      newPlgValue = defaultPlg1Value;
    else
      newPlgValue = 0.0f;

    dpSet(setPlg1Value, newPlgValue,
          setPlg1IsOn, dpValue);
  }
  else
  {
    dpSet(setValveFefBurner1IsOpened, false);
  }
}

void modelOnOrOffPlg2(string dpName, bool dpValue)
{
  bool isAuto;
  dpGet(reqAutoIsOn, isAuto);

  if (!isAuto)
  {
    float newPlgValue;

    if (dpValue)
      newPlgValue = defaultPlg2Value;
    else
      newPlgValue = 0.0f;

    dpSet(setPlg2Value, newPlgValue,
          setPlg2IsOn, dpValue);
  }
  else
  {
    dpSet(setValveFefBurner2IsOpened, false);
  }
}

void modelOnOrOffPlg3(string dpName, bool dpValue)
{
  bool isAuto;
  dpGet(reqAutoIsOn, isAuto);

  if (!isAuto)
  {
    float newPlgValue;

    if (dpValue)
      newPlgValue = defaultPlg3Value;
    else
      newPlgValue = 0.0f;

    dpSet(setPlg3Value, newPlgValue,
          setPlg3IsOn, dpValue);
  }
  else
  {
    dpSet(setValveFefBurner3IsOpened, false);
  }
}

void modelOnOrOffPlg4(string dpName, bool dpValue)
{
  bool isAuto;
  dpGet(reqAutoIsOn, isAuto);

  if (!isAuto)
  {
    float newPlgValue;

    if (dpValue)
      newPlgValue = defaultPlg4Value;
    else
      newPlgValue = 0.0f;

    dpSet(setPlg4Value, newPlgValue,
          setPlg4IsOn, dpValue);
  }
  else
  {
    dpSet(setValveFefBurner4IsOpened, false);
  }
}

void failFefNoFlow(string dpName, bool dpValue)
{
  float newFefValue;

  if (dpValue)
    newFefValue = defaultFefValue;
  else
    newFefValue = 0.0f;

  dpSet(setFefValue, newFefValue);
}

void failBurner1NoPlg1(string dpName, float dpValue)
{
  bool isBurnerOn;

  if (dpValue == 0.0f)
    isBurnerOn = false;
  else
    isBurnerOn = true;

  dpSet(setBurner1IsOn, isBurnerOn);
}

void failBurner2NoPlg2(string dpName, float dpValue)
{
  bool isBurnerOn;

  if (dpValue == 0.0f)
    isBurnerOn = false;
  else
    isBurnerOn = true;

  dpSet(setBurner2IsOn, isBurnerOn);
}

void failBurner3NoPlg3(string dpName, float dpValue)
{
  bool isBurnerOn;

  if (dpValue == 0.0f)
    isBurnerOn = false;
  else
    isBurnerOn = true;

  dpSet(setBurner3IsOn, isBurnerOn);
}

void failBurner4NoPlg4(string dpName, float dpValue)
{
  bool isBurnerOn;

  if (dpValue == 0.0f)
    isBurnerOn = false;
  else
    isBurnerOn = true;

  dpSet(setBurner4IsOn, isBurnerOn);
}
// endregion FEF

// region FEM
void modelOnOrOffFem(string dpName, bool dpValue)
{
  dpSet(setFemIsOn, dpValue);
}

void modelOnOrOffValveFemAfter(string dpName, bool dpValue)
{
  if (!dpValue)
  {
    dpSet(setValveFemBurner1IsOpened, dpValue,
          setValveFemBurner2IsOpened, dpValue,
          setValveFemBurner3IsOpened, dpValue,
          setValveFemBurner4IsOpened, dpValue);
  }
}

void modelOnOrOffFemBurner1(string dpName, bool dpValue)
{
  dpSet(setBurner1IsOn, dpValue);
}

void modelOnOrOffFemBurner2(string dpName, bool dpValue)
{
  dpSet(setBurner2IsOn, dpValue);
}

void modelOnOrOffFemBurner3(string dpName, bool dpValue)
{
  dpSet(setBurner3IsOn, dpValue);
}

void modelOnOrOffFemBurner4(string dpName, bool dpValue)
{
  dpSet(setBurner4IsOn, dpValue);
}

void failFemNoFlow(string dpName, bool dpValue)
{
  float newValue;

  if (dpValue)
    newValue = defaultFemValue;
  else
    newValue = 0.0f;

  dpSet(setFemValue, newValue);
}
// endregion FEM

// region AIR_1
void modelOnOrOffAir1Sensors(string dpName, bool dpValue)
{
  dpSet(setTra1IsOn, dpValue,
        setTra3IsOn, dpValue,
        setRah1IsOn, dpValue);
}

void modelOnOrOffValveAir1(string dpName, bool dpValue)
{
  if (!dpValue)
  {
    dpSet(setValveAirBurner1IsOpened, dpValue,
          setValveAirBurner2IsOpened, dpValue);
  }
}

void modelOnOrOffPla1(string dpName, bool dpValue)
{
  dpSet(setPla1IsOn, dpValue);
}

void modelOnOrOffPla2(string dpName, bool dpValue)
{
  dpSet(setPla2IsOn, dpValue);
}
// endregion AIR_1

// region AIR_2
void modelOnOrOffAir2Sensors(string dpName, bool dpValue)
{
  dpSet(setTra2IsOn, dpValue,
        setTra4IsOn, dpValue,
        setRah2IsOn, dpValue);
}

void modelOnOrOffValveAir2(string dpName, bool dpValue)
{
  if (!dpValue)
  {
    dpSet(setValveAirBurner3IsOpened, dpValue,
          setValveAirBurner4IsOpened, dpValue);
  }
}

void modelOnOrOffPla3(string dpName, bool dpValue)
{
  dpSet(setPla3IsOn, dpValue);
}

void modelOnOrOffPla4(string dpName, bool dpValue)
{
  dpSet(setPla4IsOn, dpValue);
}
// endregion AIR_2

// region FAN
void modelOnOrOffAirSupply(string dpName, bool dpValue)
{
  dpSet(setTra2IsOn, dpValue,
        setTra4IsOn, dpValue,
        setRah2IsOn, dpValue,
        setTra1IsOn, dpValue,
        setTra3IsOn, dpValue,
        setRah1IsOn, dpValue);
}
// region FAN

// region BURNERS
void failBrokeBurner1(string dpName, bool dpValue)
{
  if (dpValue)
  {
    bool isOpenedValveFemBurner;
    bool isOpenedValveFemAfter;
    float fuelFlowFem;
    float valuePlg;
    bool isAuto;

    dpGet(reqValveFemBurner1IsOpened, isOpenedValveFemBurner,
          reqValveFemAfterIsOpened, isOpenedValveFemAfter,
          reqFemValue, fuelFlowFem,
          reqPlg1Value, valuePlg,
          reqAutoIsOn, isAuto);

    bool canBroke = isOpenedValveFemBurner && isOpenedValveFemAfter && (fuelFlowFem > 0.0f) && (valuePlg > 0.0f);
    if (canBroke)
    {
      if (isAuto)
      {
        dpSet(setValveFefBurner1IsOpened, false);
      }
      else
      {
        dpSet(setBurner1CanWork, false,
              setBurner1IsOn, false,
              setValveFefBurner1IsOpened, false,
              setValveFemBurner1IsOpened, false);
      }
    }
  }
}

void failBrokeBurner2(string dpName, bool dpValue)
{
  if (dpValue)
  {
    bool isOpenedValveFemBurner;
    bool isOpenedValveFemAfter;
    float fuelFlowFem;
    float valuePlg;
    bool isAuto;

    dpGet(reqValveFemBurner2IsOpened, isOpenedValveFemBurner,
          reqValveFemAfterIsOpened, isOpenedValveFemAfter,
          reqFemValue, fuelFlowFem,
          reqPlg2Value, valuePlg,
          reqAutoIsOn, isAuto);

    bool canBroke = isOpenedValveFemBurner && isOpenedValveFemAfter && (fuelFlowFem > 0.0f) && (valuePlg > 0.0f);
    if (canBroke)
    {
      if (isAuto)
      {
        dpSet(setValveFefBurner3IsOpened, false);
      }
      else
      {
        dpSet(setBurner2CanWork, false,
              setBurner2IsOn, false,
              setValveFefBurner2IsOpened, false,
              setValveFemBurner2IsOpened, false);
      }
    }
  }
}

void failBrokeBurner3(string dpName, bool dpValue)
{
  if (dpValue)
  {
    bool isOpenedValveFemBurner;
    bool isOpenedValveFemAfter;
    float fuelFlowFem;
    float valuePlg;
    bool isAuto;

    dpGet(reqValveFemBurner3IsOpened, isOpenedValveFemBurner,
          reqValveFemAfterIsOpened, isOpenedValveFemAfter,
          reqFemValue, fuelFlowFem,
          reqPlg3Value, valuePlg,
          reqAutoIsOn, isAuto);

    bool canBroke = isOpenedValveFemBurner && isOpenedValveFemAfter && (fuelFlowFem > 0.0f) && (valuePlg > 0.0f);
    if (canBroke)
    {
      if (isAuto)
      {
        dpSet(setValveFefBurner3IsOpened, false);
      }
      else
      {
        dpSet(setBurner3CanWork, false,
              setBurner3IsOn, false,
              setValveFefBurner3IsOpened, false,
              setValveFemBurner3IsOpened, false);
      }
    }
  }
}

void failBrokeBurner4(string dpName, bool dpValue)
{
  if (dpValue)
  {
    bool isOpenedValveFemBurner;
    bool isOpenedValveFemAfter;
    float fuelFlowFem;
    float valuePlg;
    bool isAuto;

    dpGet(reqValveFemBurner4IsOpened, isOpenedValveFemBurner,
          reqValveFemAfterIsOpened, isOpenedValveFemAfter,
          reqFemValue, fuelFlowFem,
          reqPlg4Value, valuePlg,
          reqAutoIsOn, isAuto);

    bool canBroke = isOpenedValveFemBurner && isOpenedValveFemAfter && (fuelFlowFem > 0.0f) && (valuePlg > 0.0f);
    if (canBroke)
    {
      if (isAuto)
      {
        dpSet(setValveFefBurner4IsOpened, false);
      }
      else
      {
        dpSet(setBurner4CanWork, false,
              setBurner4IsOn, false,
              setValveFefBurner4IsOpened, false,
              setValveFemBurner4IsOpened, false);
      }
    }
  }
}
// endregion BURNERS

double uniform_law(double x, int low, int upper)
{
  return x * (upper - low + 1) + low;
}

bool isProbBroken(float prob)
{
  float currProb = rand()/32767.0;
  if (currProb > prob)
    return false;
  else
    return true;
}
