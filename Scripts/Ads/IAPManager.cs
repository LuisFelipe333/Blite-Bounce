using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Purchasing;
using System;

public class IAPManager : MonoBehaviour, IStoreListener
{
    public static IAPManager instance;

    private static IStoreController m_StoreController;
    private static IExtensionProvider m_StoreExtensionProvider;
    public GameObject padre;
    private String[] buyKeys={
        "null","null","buy_goat","buy_panda","buy_pig",
        "buy_cat_cow","buy_lion","buy_melting_cat","buy_dog","buy_frog",
        "buy_fat_cat","buy_me_perdonas","buy_sinko_peso","buy_bear_rat","buy_cute_cat",
        "buy_devil_cat","buy_anime_girl","buy_ninja_cat","buy_pedo","buy_squid",
        "buy_sad_cat","buy_bunny","buy_ovni","buy_axolotl","buy_mishi_brayan",
        "buy_mishi_eat","buy_uganda","buy_cuernos","buy_mishi_pirata","buy_castor",
        "buy_panda_cool","buy_fungus","buy_cheems"
    };
    
    public String buy20Stars="buy20Stars";
    public String supportDeveloper="supportDeveloper";
    //Step 1 create your products

    

    //************************** Adjust these methods **************************************
    public void InitializePurchasing()
    {
        if (IsInitialized()) { return; }
        var builder = ConfigurationBuilder.Instance(StandardPurchasingModule.Instance());

        //Step 2 choose if your product is a consumable or non consumable
        
        /*for(int i=1;i<padre.transform.childCount;i++)
        buyKeys[padre.transform.GetChild(i).GetComponent<SaveSkinNumber>().skinNumber]=DatosSkins.datosSkins.llavesVenta[padre.transform.GetChild(i).GetComponent<SaveSkinNumber>().skinNumber];
        
        for(int i=1;i<padre.transform.childCount;i++)
        builder.AddProduct(buyKeys[padre.transform.GetChild(i).GetComponent<SaveSkinNumber>().skinNumber],ProductType.NonConsumable);
        */
        for(int i=0;i<buyKeys.Length;i++)
        builder.AddProduct(buyKeys[i],ProductType.NonConsumable);

        builder.AddProduct(buy20Stars,ProductType.Consumable);
        builder.AddProduct(supportDeveloper,ProductType.Consumable);

        UnityPurchasing.Initialize(this, builder);
    }


    private bool IsInitialized()
    {
        return m_StoreController != null && m_StoreExtensionProvider != null;
    }


    //Step 3 Create methods

    public void BuyCharacter(int skinNumber)
    {
        FindFather();
        BuyProductID(buyKeys[skinNumber]);
    }

    public void Buy20Stars()
    {
        FindFather();
        BuyProductID(buy20Stars);
    }

    public void SupportDeveloper()
    {
        FindFather();
        BuyProductID(supportDeveloper);
    }


    //Step 4 modify purchasing
    public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs args)
    {
        bool pass=false;
        for(int i=0;i<buyKeys.Length;i++)
        {
            
                if (String.Equals(args.purchasedProduct.definition.id,  buyKeys[i] , StringComparison.Ordinal))
                {
                    Debug.Log(buyKeys[i]+" Succesful" );
                    pass=true;
                    DatosSkins.datosSkins.skinConseguida=i;
                    DatosSkins.datosSkins.skinSeleccionada=i;
                    DatosSkins.datosSkins.GuardarListaSkins();
                                   
                    padre.GetComponent<ColocateSkinsShop>().actualizar();
                }
            
        }

        if(String.Equals(args.purchasedProduct.definition.id, buy20Stars , StringComparison.Ordinal))
        {
            Debug.Log(buy20Stars+" Succesful");
            pass=true;
            EstadoJuego.estadoJuego.numeroEstrellas+=20;
        }

        if(String.Equals(args.purchasedProduct.definition.id, supportDeveloper , StringComparison.Ordinal))
        {
            Debug.Log(supportDeveloper+" Succesful");
            pass=true;
        }

        if(!pass)
        Debug.Log("Purchase Failed");
              
        return PurchaseProcessingResult.Complete;
    }





    //**************************** Dont worry about these methods ***********************************

    public void FindFather()
    {
        padre=GameObject.Find("Padre");
    }

    private void Awake()
    {
        
        TestSingleton();
    }

    void Start()
    {
        if (m_StoreController == null) { InitializePurchasing(); }

    }

    private void TestSingleton()
    {
        if (instance != null) { Destroy(gameObject); return; }
        instance = this;
        DontDestroyOnLoad(gameObject);
    }

    void BuyProductID(string productId)
    {
        if (IsInitialized())
        {
            Product product = m_StoreController.products.WithID(productId);
            if (product != null && product.availableToPurchase)
            {
                Debug.Log(string.Format("Purchasing product asychronously: '{0}'", product.definition.id));
                m_StoreController.InitiatePurchase(product);
            }
            else
            {
                Debug.Log("BuyProductID: FAIL. Not purchasing product, either is not found or is not available for purchase");
            }
        }
        else
        {
            Debug.Log("BuyProductID FAIL. Not initialized.");
        }
    }

    public void RestorePurchases()
    {
        if (!IsInitialized())
        {
            Debug.Log("RestorePurchases FAIL. Not initialized.");
            return;
        }

        if (Application.platform == RuntimePlatform.IPhonePlayer ||
            Application.platform == RuntimePlatform.OSXPlayer)
        {
            Debug.Log("RestorePurchases started ...");

            var apple = m_StoreExtensionProvider.GetExtension<IAppleExtensions>();
            apple.RestoreTransactions((result) => {
                Debug.Log("RestorePurchases continuing: " + result + ". If no further messages, no purchases available to restore.");
            });
        }
        else
        {
            Debug.Log("RestorePurchases FAIL. Not supported on this platform. Current = " + Application.platform);
        }
    }

    public void OnInitialized(IStoreController controller, IExtensionProvider extensions)
    {
        Debug.Log("OnInitialized: PASS");
        m_StoreController = controller;
        m_StoreExtensionProvider = extensions;
    }


    public void OnInitializeFailed(InitializationFailureReason error)
    {
        Debug.Log("OnInitializeFailed InitializationFailureReason:" + error);
    }

    public void OnPurchaseFailed(Product product, PurchaseFailureReason failureReason)
    {
        Debug.Log(string.Format("OnPurchaseFailed: FAIL. Product: '{0}', PurchaseFailureReason: {1}", product.definition.storeSpecificId, failureReason));
    }
}