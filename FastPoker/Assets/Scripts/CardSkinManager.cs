using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class CardSkinManager : MonoBehaviour
{
    [SerializeField] private AssetReference _assetReference;

    private static Sprite[] _cardSkins = null;

    [SerializeField] private AssetLabelReference _label;
    
    public static GameControls GameControls { get; private set; }

    private void Awake()
    {
        Addressables.LoadAssetAsync<Sprite[]>(_assetReference).Completed += SpriteLoad;

        GameControls = new GameControls();
        
        GameControls.Controls.Enable();
    }

    private void SpriteLoad(AsyncOperationHandle<Sprite[]> context)
    {
        switch (context.Status)
        {
            case AsyncOperationStatus.Succeeded:
                _cardSkins = context.Result;
                break;
            case AsyncOperationStatus.Failed:
                Debug.LogError("Sprite load Failed.");
                break;
            default:
                // case AsyncOperationStatus.None:
                break;
        }
    }

    public static Sprite GetSpriteOfCard(Card card)
    {
        return _cardSkins?[GetCardIndex(card)];
    }

    public static int GetCardIndex(Card card)
    {
        if (_cardSkins == null)
            return 52;
        
        if (!card.Hidden)
            return ((int) card.Suite * 13) + (int) card.Value - 1;
        else
            return _cardSkins.Length - 1;
    }
}