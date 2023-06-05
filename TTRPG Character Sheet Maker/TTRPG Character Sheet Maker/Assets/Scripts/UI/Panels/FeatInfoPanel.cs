using UnityEngine;
using UnityEngine.UI;
using TMPro;
using TTRPG.UI;
using TTRPG.Data;

public class FeatInfoPanel : MonoBehaviour
{
    #region Fields
    public FeatCard Card;

    [SerializeField] private TMP_InputField titleField;
    [SerializeField] private TMP_InputField featSourceField;
    [SerializeField] private TMP_InputField descriptionField;
    [SerializeField] private Button backButton;
    [SerializeField] private Button saveButton;

    private Feat info;
    #endregion Fields

    #region UnityCallbacks
    private void Start()
    {
        titleField.onValueChanged.AddListener(OnValueChanged);
        featSourceField.onValueChanged.AddListener(OnValueChanged);
        descriptionField.onValueChanged.AddListener(OnValueChanged);
        backButton.onClick.AddListener(OnBackButtonClick);
        saveButton.onClick.AddListener(OnSaveButtonClick);
    }

    private void OnDestroy()
    {
        titleField.onValueChanged.RemoveListener(OnValueChanged);
        featSourceField.onValueChanged.RemoveListener(OnValueChanged);
        descriptionField.onValueChanged.RemoveListener(OnValueChanged);
        backButton.onClick.RemoveListener(OnBackButtonClick);
        saveButton.onClick.RemoveListener(OnSaveButtonClick);
    }
    #endregion UnityCallbacks

    #region Methods
    public void Initialize(FeatCard card)
    {
        Card = card;
        info = card.Value;
        SetFieldsText(info.title, info.feat_source, info.description);
        backButton.gameObject.SetActive(true);
        saveButton.gameObject.SetActive(false);
        gameObject.SetActive(true);
    }

    public void SetFieldsText(string title, string featSource, string description)
    {
        titleField.SetTextWithoutNotify(title);
        featSourceField.SetTextWithoutNotify(featSource);
        descriptionField.SetTextWithoutNotify(description);
    }

    private void SaveChanges()
    {
        info.title = titleField.text;
        info.feat_source = featSourceField.text;
        info.description = descriptionField.text;
    }

    private void OnValueChanged(string value)
    {
        if (string.IsNullOrWhiteSpace(titleField.text))
            saveButton.gameObject.SetActive(false);
        else
            saveButton.gameObject.SetActive(true);
    }
    private void OnBackButtonClick() => gameObject.SetActive(false);
    private void OnSaveButtonClick()
    {
        SaveChanges();
        Card.Initialize(info);
        gameObject.SetActive(false);
    }
    #endregion Methods
}
