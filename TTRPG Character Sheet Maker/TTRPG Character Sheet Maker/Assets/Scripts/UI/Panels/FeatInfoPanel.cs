using UnityEngine;
using UnityEngine.UI;
using TMPro;
using TTRPG.Data;

public class FeatInfoPanel : MonoBehaviour
{
    #region Fields
    public Feat Info;

    [SerializeField] private TMP_InputField titleField;
    [SerializeField] private TMP_InputField featSourceField;
    [SerializeField] private TMP_InputField descriptionField;
    [SerializeField] private Button backButton;
    [SerializeField] private Button editButton;
    [SerializeField] private Button saveButton;

    private bool isEditing;
    #endregion Fields

    #region UnityCallbacks
    private void OnEnable() => isEditing = false;

    private void Start()
    {
        backButton.onClick.AddListener(OnBackButtonClick);
        editButton.onClick.AddListener(OnEditButtonClick);
        saveButton.onClick.AddListener(OnSaveButtonClick);
    }

    private void OnDestroy()
    {
        backButton.onClick.RemoveListener(OnBackButtonClick);
        editButton.onClick.RemoveListener(OnEditButtonClick);
        saveButton.onClick.RemoveListener(OnSaveButtonClick);
    }
    #endregion UnityCallbacks

    #region Methods
    public void Initialize(Feat feat)
    {
        Info = feat;
        SetFieldsText(Info.title, Info.feat_source, Info.description);
        SetFieldsInteractable(false);
        backButton.gameObject.SetActive(true);
        editButton.gameObject.SetActive(true);
        saveButton.gameObject.SetActive(false);
    }

    public void SetFieldsText(string title, string featSource, string description)
    {
        titleField.SetTextWithoutNotify(title);
        featSourceField.SetTextWithoutNotify(featSource);
        descriptionField.SetTextWithoutNotify(description);
    }

    public void SetFieldsInteractable(bool isInteractable)
    {
        titleField.interactable = isInteractable;
        featSourceField.interactable = isInteractable;
        descriptionField.interactable = isInteractable;
    }

    private void OnEditingChange(bool isEditing)
    {
        isEditing = !isEditing;
        SetFieldsInteractable(isEditing);
        editButton.gameObject.SetActive(!isEditing);
        saveButton.gameObject.SetActive(isEditing);
    }

    #region Buttons
    private void OnBackButtonClick()
    {
        if (isEditing)
        {
            SetFieldsText(Info.title, Info.feat_source, Info.description);
            OnEditingChange(false);
        }
        else
            gameObject.SetActive(false);
    }
    private void OnEditButtonClick() => OnEditingChange(true);
    private void OnSaveButtonClick()
    {
        OnEditingChange(false);
        Info.title = titleField.text;
        Info.feat_source = featSourceField.text;
        Info.description = descriptionField.text;
    }
    #endregion Buttons
    #endregion Methods
}
