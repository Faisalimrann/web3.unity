using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileSendTransactionExample : MonoBehaviour
{
 async public void OnSendTransaction()
    {
        // https://chainlist.org/
        string chainId = "4"; // rinkeby
        // account to send to
        string to = "0xdD4c825203f97984e7867F11eeCc813A036089D1";
        // value in wei
        string value = "12300000000000000";
        // data OPTIONAL
        string data = "";
        // gas limit OPTIONAL
        string gasLimit = "";
        // gas price OPTIONAL
        string gasPrice = "";
        // send transaction
        string response = await Web3Mobile.SendTransaction(chainId, to, value, data, gasLimit, gasPrice);
        print(response);
    }
}
